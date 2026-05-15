namespace Proyecto_Sistemas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIng_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "admin" && txtPass.Text == "123")
            {
                Menu menu = new Menu(); 
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
