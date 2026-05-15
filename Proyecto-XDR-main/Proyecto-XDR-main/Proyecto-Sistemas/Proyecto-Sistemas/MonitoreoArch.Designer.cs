namespace Proyecto_Sistemas
{
    partial class MonitoreoArch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonitoreoArch));
            txtRuta = new TextBox();
            LBLCPU = new Label();
            label4 = new Label();
            label1 = new Label();
            btnBuscar = new Button();
            button4 = new Button();
            EVENTOS = new ListBox();
            label2 = new Label();
            HISTORIAL = new ListBox();
            lblEstado = new Label();
            progressBar1 = new ProgressBar();
            btnInicio = new Button();
            groupBox1 = new GroupBox();
            groupBox5 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // txtRuta
            // 
            txtRuta.Location = new Point(205, 76);
            txtRuta.Margin = new Padding(3, 2, 3, 2);
            txtRuta.Name = "txtRuta";
            txtRuta.Size = new Size(279, 23);
            txtRuta.TabIndex = 2;
            // 
            // LBLCPU
            // 
            LBLCPU.AutoSize = true;
            LBLCPU.Font = new Font("Book Antiqua", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLCPU.ForeColor = SystemColors.ControlLightLight;
            LBLCPU.Location = new Point(6, 69);
            LBLCPU.Name = "LBLCPU";
            LBLCPU.Size = new Size(89, 28);
            LBLCPU.TabIndex = 3;
            LBLCPU.Text = "RUTA:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Book Antiqua", 27.75F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(117, 39);
            label4.Name = "label4";
            label4.Size = new Size(552, 44);
            label4.TabIndex = 6;
            label4.Text = "MONITOREO DE ARCHIVOS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(173, 18);
            label1.Name = "label1";
            label1.Size = new Size(343, 33);
            label1.TabIndex = 7;
            label1.Text = "ARCHIVOS POR RUTA";
            // 
            // btnBuscar
            // 
            btnBuscar.AutoEllipsis = true;
            btnBuscar.BackColor = Color.FromArgb(2, 28, 32);
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Font = new Font("Book Antiqua", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = SystemColors.ControlLightLight;
            btnBuscar.Location = new Point(504, 115);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(116, 30);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "INICIAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(2, 28, 32);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Book Antiqua", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(205, 152);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(157, 36);
            button4.TabIndex = 11;
            button4.Text = "INICIAR";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // EVENTOS
            // 
            EVENTOS.BackColor = Color.MidnightBlue;
            EVENTOS.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EVENTOS.ForeColor = Color.White;
            EVENTOS.FormattingEnabled = true;
            EVENTOS.Location = new Point(27, 37);
            EVENTOS.Name = "EVENTOS";
            EVENTOS.Size = new Size(629, 284);
            EVENTOS.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Book Antiqua", 27.75F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(859, 9);
            label2.Name = "label2";
            label2.Size = new Size(519, 44);
            label2.TabIndex = 14;
            label2.Text = "HISTORIAL DE ARCHIVOS";
            label2.Click += label2_Click;
            // 
            // HISTORIAL
            // 
            HISTORIAL.BackColor = Color.MidnightBlue;
            HISTORIAL.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HISTORIAL.ForeColor = Color.White;
            HISTORIAL.FormattingEnabled = true;
            HISTORIAL.Location = new Point(18, 36);
            HISTORIAL.Name = "HISTORIAL";
            HISTORIAL.Size = new Size(622, 479);
            HISTORIAL.TabIndex = 15;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Book Antiqua", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstado.ForeColor = SystemColors.ControlLightLight;
            lblEstado.Location = new Point(6, 111);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(123, 28);
            lblEstado.TabIndex = 16;
            lblEstado.Text = "ESTADO:";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(205, 115);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(279, 24);
            progressBar1.TabIndex = 17;
            progressBar1.Click += progressBar1_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(2, 28, 32);
            btnInicio.FlatStyle = FlatStyle.Popup;
            btnInicio.Font = new Font("Book Antiqua", 18F, FontStyle.Bold);
            btnInicio.ForeColor = SystemColors.ControlLightLight;
            btnInicio.Location = new Point(434, 29);
            btnInicio.Margin = new Padding(3, 2, 3, 2);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(186, 54);
            btnInicio.TabIndex = 4;
            btnInicio.Text = "INICIO";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(groupBox5);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(22, 85);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(693, 266);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.LightSlateGray;
            groupBox5.Controls.Add(label3);
            groupBox5.Controls.Add(btnBuscar);
            groupBox5.Controls.Add(label1);
            groupBox5.Controls.Add(LBLCPU);
            groupBox5.Controls.Add(progressBar1);
            groupBox5.Controls.Add(button4);
            groupBox5.Controls.Add(txtRuta);
            groupBox5.Controls.Add(lblEstado);
            groupBox5.FlatStyle = FlatStyle.Flat;
            groupBox5.ForeColor = Color.Cyan;
            groupBox5.Location = new Point(27, 30);
            groupBox5.Margin = new Padding(3, 2, 3, 2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 2, 3, 2);
            groupBox5.Size = new Size(640, 215);
            groupBox5.TabIndex = 21;
            groupBox5.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(EVENTOS);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Location = new Point(22, 367);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(693, 358);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(HISTORIAL);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Location = new Point(758, 55);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(664, 544);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.LightSlateGray;
            groupBox4.Controls.Add(btnInicio);
            groupBox4.FlatStyle = FlatStyle.Flat;
            groupBox4.ForeColor = Color.Cyan;
            groupBox4.Location = new Point(758, 620);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(640, 105);
            groupBox4.TabIndex = 20;
            groupBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(6, 155);
            label3.Name = "label3";
            label3.Size = new Size(173, 28);
            label3.TabIndex = 18;
            label3.Text = "MONITOREO";
            // 
            // MonitoreoArch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1434, 761);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MonitoreoArch";
            Text = "MonitoreoArch";
            Load += MonitoreoArch_Load;
            groupBox1.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtRuta;
        private Label LBLCPU;
        private Label label4;
        private Label label1;
        private Button btnBuscar;
        private Button button4;
        private ListBox EVENTOS;
        private Label label2;
        private ListBox HISTORIAL;
        private Label lblEstado;
        private ProgressBar progressBar1;
        private Button btnInicio;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Label label3;
    }
}