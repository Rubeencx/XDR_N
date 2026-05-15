namespace Proyecto_Sistemas
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            btnInicio = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            btnSalir = new Button();
            btnAlertas = new Button();
            btnMonArch = new Button();
            button1 = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.Transparent;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatAppearance.MouseDownBackColor = Color.Cyan;
            btnInicio.FlatAppearance.MouseOverBackColor = Color.Black;
            btnInicio.FlatStyle = FlatStyle.Popup;
            btnInicio.Font = new Font("Book Antiqua", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicio.ForeColor = SystemColors.ControlLightLight;
            btnInicio.Location = new Point(1175, 629);
            btnInicio.Margin = new Padding(3, 2, 3, 2);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(221, 109);
            btnInicio.TabIndex = 4;
            btnInicio.Text = "INICIO";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(983, 304);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(336, 255);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Book Antiqua", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(366, 22);
            label2.Name = "label2";
            label2.Size = new Size(416, 57);
            label2.TabIndex = 10;
            label2.Text = "PROYECTO XDR";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Transparent;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseDownBackColor = Color.LightGreen;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.Black;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Font = new Font("Book Antiqua", 27.75F, FontStyle.Bold);
            btnSalir.ForeColor = SystemColors.ControlLightLight;
            btnSalir.Location = new Point(3, 601);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(326, 128);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnAlertas
            // 
            btnAlertas.BackColor = Color.Transparent;
            btnAlertas.FlatAppearance.BorderSize = 0;
            btnAlertas.FlatAppearance.MouseDownBackColor = Color.LightGreen;
            btnAlertas.FlatAppearance.MouseOverBackColor = Color.Black;
            btnAlertas.FlatStyle = FlatStyle.Popup;
            btnAlertas.Font = new Font("Book Antiqua", 27.75F, FontStyle.Bold);
            btnAlertas.ForeColor = SystemColors.ControlLightLight;
            btnAlertas.Location = new Point(0, 462);
            btnAlertas.Margin = new Padding(3, 2, 3, 2);
            btnAlertas.Name = "btnAlertas";
            btnAlertas.Size = new Size(332, 128);
            btnAlertas.TabIndex = 3;
            btnAlertas.Text = "ALERTAS";
            btnAlertas.UseVisualStyleBackColor = false;
            // 
            // btnMonArch
            // 
            btnMonArch.BackColor = Color.Transparent;
            btnMonArch.FlatAppearance.BorderSize = 0;
            btnMonArch.FlatAppearance.MouseDownBackColor = Color.LightGreen;
            btnMonArch.FlatAppearance.MouseOverBackColor = Color.Black;
            btnMonArch.FlatStyle = FlatStyle.Popup;
            btnMonArch.Font = new Font("Book Antiqua", 27.75F, FontStyle.Bold);
            btnMonArch.ForeColor = Color.White;
            btnMonArch.Location = new Point(3, 318);
            btnMonArch.Margin = new Padding(3, 2, 3, 2);
            btnMonArch.Name = "btnMonArch";
            btnMonArch.Size = new Size(332, 128);
            btnMonArch.TabIndex = 2;
            btnMonArch.Text = "MONITOREO DE ARCHIVOS";
            btnMonArch.UseVisualStyleBackColor = false;
            btnMonArch.Click += btnMonArch_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.LightGreen;
            button1.FlatAppearance.MouseOverBackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Book Antiqua", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(-7, 174);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(339, 128);
            button1.TabIndex = 1;
            button1.Text = "MONITOREO DEL SISTEMA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOliveGreen;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnMonArch);
            panel1.Controls.Add(btnAlertas);
            panel1.Controls.Add(btnSalir);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.MinimumSize = new Size(250, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 761);
            panel1.TabIndex = 9;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1434, 761);
            Controls.Add(btnInicio);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnInicio;
        private PictureBox pictureBox1;
        private Label label2;
        private Button btnSalir;
        private Button btnAlertas;
        private Button btnMonArch;
        private Button button1;
        private Panel panel1;
    }
}