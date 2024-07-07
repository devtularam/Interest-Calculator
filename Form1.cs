using System.Diagnostics;

namespace Interest_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double principal, rate, duration, interest;
            principal = float.Parse(textBox1.Text);
            rate = float.Parse(textBox2.Text);
            duration = float.Parse(textBox3.Text);


            interest = (principal / 100 * rate) / 12 * duration;

            label8.Text = interest.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "".ToString();
            textBox2.Text = "".ToString();
            textBox3.Text = "".ToString();
            label8.Text = "--".ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
           
        }
    }
}
