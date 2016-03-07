using System;
using System.Windows.Forms;

namespace AbstractFactoryPattern
{
    public partial class Form1 : Form
    {
        private Car c;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c = new Car(new BMWCarFactory());
            label1.Text = c.ToString();
            label2.Text = "No information yet";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c = new Car(new AudiCarFactory());
            label1.Text = c.ToString();
            label2.Text = "No information yet";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c = new Car(new MercedesCarFactory());
            label1.Text = c.ToString();
            label2.Text = "No information yet";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = c.Drive();
        }
    }
}