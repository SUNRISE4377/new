namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox2.Enabled = false;
            }
            else
            {
                textBox2.Enabled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                textBox1.Enabled = false;
            }
            else
            {
                textBox1.Enabled = true;
            }
        }
    }
}