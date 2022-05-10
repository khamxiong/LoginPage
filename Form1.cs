namespace WinFormsApp2
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textUsername.Text == "kham" && textPassword.Text == "12345")
            {
                new MainForm().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("pleasetry again userName  or Password you entered is incorrected");
                textUsername.Clear();
                textPassword.Clear();
                textUsername.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            textUsername.Clear();
            textPassword.Clear();
            textUsername.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}