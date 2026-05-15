namespace Proyecto_Sistemas
{
    partial class MonitoreoSis
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonitoreoSis));
            LBLCPU = new Label();
            LBLRAM = new Label();
            LBLDISK = new Label();
            label4 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            listView1 = new ListView();
            label1 = new Label();
            btnInicio = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // LBLCPU
            // 
            LBLCPU.AutoSize = true;
            LBLCPU.Font = new Font("Book Antiqua", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLCPU.ForeColor = SystemColors.ControlLightLight;
            LBLCPU.Location = new Point(21, 45);
            LBLCPU.Name = "LBLCPU";
            LBLCPU.Size = new Size(69, 28);
            LBLCPU.TabIndex = 2;
            LBLCPU.Text = "CPU:";
            // 
            // LBLRAM
            // 
            LBLRAM.AutoSize = true;
            LBLRAM.Font = new Font("Book Antiqua", 18F, FontStyle.Bold);
            LBLRAM.ForeColor = SystemColors.ControlLightLight;
            LBLRAM.Location = new Point(21, 144);
            LBLRAM.Name = "LBLRAM";
            LBLRAM.Size = new Size(78, 28);
            LBLRAM.TabIndex = 3;
            LBLRAM.Text = "RAM:";
            // 
            // LBLDISK
            // 
            LBLDISK.AutoSize = true;
            LBLDISK.Font = new Font("Book Antiqua", 18F, FontStyle.Bold);
            LBLDISK.ForeColor = SystemColors.ControlLightLight;
            LBLDISK.Location = new Point(21, 239);
            LBLDISK.Name = "LBLDISK";
            LBLDISK.Size = new Size(99, 28);
            LBLDISK.TabIndex = 4;
            LBLDISK.Text = "DISCO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Book Antiqua", 27.75F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(207, 74);
            label4.Name = "label4";
            label4.Size = new Size(538, 44);
            label4.TabIndex = 5;
            label4.Text = "MONITOREO DEL SISTEMA";
            // 
            // timer1
            // 
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 2000;
            // 
            // listView1
            // 
            listView1.BackColor = Color.DarkSlateGray;
            listView1.Location = new Point(37, 50);
            listView1.Margin = new Padding(3, 2, 3, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(727, 509);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Book Antiqua", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(884, 74);
            label1.Name = "label1";
            label1.Size = new Size(525, 43);
            label1.TabIndex = 7;
            label1.Text = "PROCESOS EN TIEMPO REAL";
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.MidnightBlue;
            btnInicio.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            btnInicio.FlatAppearance.MouseOverBackColor = Color.Black;
            btnInicio.FlatStyle = FlatStyle.Popup;
            btnInicio.Font = new Font("Book Antiqua", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicio.ForeColor = SystemColors.ControlLightLight;
            btnInicio.Location = new Point(1227, 674);
            btnInicio.Margin = new Padding(3, 2, 3, 2);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(186, 54);
            btnInicio.TabIndex = 4;
            btnInicio.Text = "INICIO";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(listView1);
            panel1.Location = new Point(41, 133);
            panel1.Name = "panel1";
            panel1.Size = new Size(811, 595);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(LBLRAM);
            panel2.Controls.Add(LBLCPU);
            panel2.Controls.Add(LBLDISK);
            panel2.Location = new Point(884, 133);
            panel2.Name = "panel2";
            panel2.Size = new Size(529, 348);
            panel2.TabIndex = 9;
            // 
            // MonitoreoSis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1434, 761);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnInicio);
            Controls.Add(label4);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MonitoreoSis";
            Text = "MonitoreoSis";
            Load += MonitoreoSis_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBLCPU;
        private Label LBLRAM;
        private Label LBLDISK;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private ListView listView1;
        private Label label1;
        private Button btnInicio;
        private Panel panel1;
        private Panel panel2;
    }
}