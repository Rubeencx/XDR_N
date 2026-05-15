using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Windows.Forms;


namespace Proyecto_Sistemas
{

    public partial class MonitoreoSis : Form
    {
        Dictionary<int, TimeSpan> ultimoTiempoCPU = new Dictionary<int, TimeSpan>();
        DateTime ultimoTiempoMedicion = DateTime.Now;
        PerformanceCounter cpu = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        PerformanceCounter ram = new PerformanceCounter("Memory", "Available MBytes");
        PerformanceCounter disk = new PerformanceCounter("PhysicalDisk", "% Disk Time", "_Total");

        public MonitoreoSis()
        {
            InitializeComponent();
            timer1.Interval = 2000;
            timer1.Start();
            typeof(ListView).InvokeMember("DoubleBuffered",
        System.Reflection.BindingFlags.NonPublic |
        System.Reflection.BindingFlags.Instance |
        System.Reflection.BindingFlags.SetProperty,
        null, listView1, new object[] { true });

            timer1.Interval = 2000;
            timer1.Start();
        }

        private void MonitoreoSis_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.HideSelection = false;
            listView1.Columns.Clear();
            listView1.Columns.Add("Proceso", 250);
            listView1.Columns.Add("RAM (MB)", 80);
            listView1.Columns.Add("CPU (%)", 80);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LBLCPU.Text = "CPU: " + cpu.NextValue().ToString("0.00") + "%";
            LBLRAM.Text = "RAM libre: " + ram.NextValue() + " MB";
            LBLDISK.Text = "Disco: " + disk.NextValue().ToString("0.00") + "%";
            CargarProcesos();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CargarProcesos()
        {
            var procesos = Process.GetProcesses();
            DateTime ahora = DateTime.Now;
            double intervalo = (ahora - ultimoTiempoMedicion).TotalMilliseconds;

            int topIndex = 0;
            if (listView1.Items.Count > 0)
                topIndex = listView1.TopItem.Index;

            foreach (Process p in procesos)
            {
                try
                {
                    string nombre = p.ProcessName;
                    int ramMB = (int)(p.WorkingSet64 / 1024 / 1024);

                    double cpuUso = 0;

                    if (ultimoTiempoCPU.ContainsKey(p.Id))
                    {
                        var tiempoPrevio = ultimoTiempoCPU[p.Id];
                        var tiempoActual = p.TotalProcessorTime;

                        var uso = (tiempoActual - tiempoPrevio).TotalMilliseconds;

                        cpuUso = uso / (Environment.ProcessorCount * intervalo) * 100;
                    }

                    ultimoTiempoCPU[p.Id] = p.TotalProcessorTime;

                    ListViewItem item = listView1.Items
                        .Cast<ListViewItem>()
                        .FirstOrDefault(i => i.Text == nombre);

                    if (item != null)
                    {
                        item.SubItems[1].Text = ramMB.ToString();
                        item.SubItems[2].Text = cpuUso.ToString("0.0");
                    }
                    else
                    {
                        item = new ListViewItem(nombre);
                        item.SubItems.Add(ramMB.ToString());
                        item.SubItems.Add(cpuUso.ToString("0.0"));

                        listView1.Items.Add(item);
                    }

                    if (cpuUso > 50)
                        item.BackColor = Color.LightCoral;
                    else if (cpuUso > 20)
                        item.BackColor = Color.Khaki;
                    else
                        item.BackColor = Color.LightGreen;
                }
                catch { }
            }

            ultimoTiempoMedicion = ahora;

            if (listView1.Items.Count > 0 && topIndex < listView1.Items.Count)
                listView1.TopItem = listView1.Items[topIndex];
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void btnAlertas_Click(object sender, EventArgs e)
        {

        }
    }
}
