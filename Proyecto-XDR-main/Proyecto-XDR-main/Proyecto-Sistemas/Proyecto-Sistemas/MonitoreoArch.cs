using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Linq;

namespace Proyecto_Sistemas
{
    public partial class MonitoreoArch : Form
    {
        FileSystemWatcher watcher;
        string logFile = @"C:\Monitoreo\log.txt";
        bool monitoreando = false;

        public MonitoreoArch()
        {
            InitializeComponent();

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void btnMoni_Click(object sender, EventArgs e)
        {
            MonitoreoSis mon = new MonitoreoSis();
            mon.Show();
            this.Hide();
        }

        private void btnMonArch_Click(object sender, EventArgs e)
        {
            MonitoreoArch arch = new MonitoreoArch();
            arch.Show();
            this.Hide();
        }

        private void MonitoreoArch_Load(object sender, EventArgs e)
        {
            EVENTOS.DrawMode = DrawMode.OwnerDrawFixed;
            EVENTOS.DrawItem += listEventos_DrawItem;
            CargarHistorial();
        }
        private void listEventos_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            string texto = EVENTOS.Items[e.Index].ToString();

            Color color = Color.White;

            if (texto.Contains("ELIMINADO"))
                color = Color.Red;

            else if (texto.Contains("MODIFICADO"))
                color = Color.Orange;

            else if (texto.Contains("CREADO"))
                color = Color.LightGreen;

            else if (texto.Contains("RENOMBRADO"))
                color = Color.Yellow;

            e.DrawBackground();

            using (Brush brush = new SolidBrush(color))
            {
                e.Graphics.DrawString(texto, e.Font, brush, e.Bounds);
            }

            e.DrawFocusRectangle();
        }
        private void CargarHistorial()
        {
            string rutaLog = @"C:\Monitoreo\log.txt";

            if (!File.Exists(rutaLog))
            {
                return;
            }

            string[] lineas = File.ReadAllLines(rutaLog);

            HISTORIAL.Items.Clear();

            foreach (string linea in lineas)
            {
                HISTORIAL.Items.Add(linea);
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {

            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtRuta.Text = dialog.SelectedPath;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (!monitoreando)
            {

                if (!Directory.Exists(txtRuta.Text))
                {
                    MessageBox.Show("Ruta inválida");
                    return;
                }

                watcher = new FileSystemWatcher();
                watcher.Path = txtRuta.Text;
                watcher.IncludeSubdirectories = true;

                watcher.NotifyFilter = NotifyFilters.FileName
                                     | NotifyFilters.LastWrite
                                     | NotifyFilters.Size;

                watcher.Created += OnCreated;
                watcher.Changed += OnChanged;
                watcher.Deleted += OnDeleted;
                watcher.Renamed += OnRenamed;

                watcher.EnableRaisingEvents = true;

                monitoreando = true;
                progressBar1.Style = ProgressBarStyle.Marquee;
                progressBar1.MarqueeAnimationSpeed = 30;
                button4.Text = "Parar monitoreo";
                button4.BackColor = Color.Red;
                MessageBox.Show("Monitoreo iniciado");
                lblEstado.Text = "Estado: Monitoreando";
            }
            else
            {
                watcher.EnableRaisingEvents = false;
                watcher.Dispose();

                monitoreando = false;
                progressBar1.MarqueeAnimationSpeed = 0;
                progressBar1.Style = ProgressBarStyle.Blocks;
                progressBar1.Value = 0;
                button4.Text = "Iniciar monitoreo";
                button4.BackColor = Color.DodgerBlue;
                lblEstado.Text = "Estado: Detenido";
                EVENTOS.Items.Clear();
                MessageBox.Show("Monitoreo detenido");

            }
        }

        private void RegistrarEvento(string tipo, string archivo)
        {
            string mensaje = $"{DateTime.Now} - {tipo}: {archivo}";


            if (InvokeRequired)
            {
                Invoke(new Action(() => EVENTOS.Items.Add(mensaje)));
            }
            else
            {
                EVENTOS.Items.Add(mensaje);
            }

            File.AppendAllText(@"C:\Monitoreo\log.txt", mensaje + Environment.NewLine);
        }

        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            RegistrarEvento("CREADO", e.FullPath);
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            RegistrarEvento("MODIFICADO", e.FullPath);
        }

        private void OnDeleted(object sender, FileSystemEventArgs e)
        {
            RegistrarEvento("ELIMINADO", e.FullPath);
        }

        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            RegistrarEvento("RENOMBRADO", e.FullPath);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}


