namespace Proyecto_Sistemas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnIng = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            txtPass = new TextBox();
            txtUser = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnIng
            // 
            btnIng.BackColor = Color.FromArgb(2, 28, 32);
            btnIng.FlatStyle = FlatStyle.Popup;
            btnIng.Font = new Font("Book Antiqua", 18F, FontStyle.Bold);
            btnIng.ForeColor = SystemColors.ControlLightLight;
            btnIng.Location = new Point(776, 619);
            btnIng.Margin = new Padding(3, 2, 3, 2);
            btnIng.Name = "btnIng";
            btnIng.Size = new Size(186, 54);
            btnIng.TabIndex = 0;
            btnIng.Text = "INGRESAR";
            btnIng.UseVisualStyleBackColor = false;
            btnIng.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(txtPass);
            groupBox1.Controls.Add(txtUser);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(607, 99);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(479, 475);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 18F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(111, 343);
            label3.Name = "label3";
            label3.Size = new Size(196, 28);
            label3.TabIndex = 6;
            label3.Text = "CONTRASEÑA:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(170, 50);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Book Antiqua", 18F, FontStyle.Bold);
            txtPass.Location = new Point(111, 382);
            txtPass.Margin = new Padding(3, 2, 3, 2);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(269, 36);
            txtPass.TabIndex = 4;
            txtPass.TextChanged += textBox2_TextChanged;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Book Antiqua", 18F, FontStyle.Bold);
            txtUser.Location = new Point(111, 281);
            txtUser.Margin = new Padding(3, 2, 3, 2);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(269, 36);
            txtUser.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 18F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(111, 251);
            label1.Name = "label1";
            label1.Size = new Size(136, 28);
            label1.TabIndex = 1;
            label1.Text = "USUARIO:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1434, 761);
            Controls.Add(groupBox1);
            Controls.Add(btnIng);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnIng;
        private GroupBox groupBox1;
        private TextBox txtPass;
        private TextBox txtUser;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox1;
    }
}
