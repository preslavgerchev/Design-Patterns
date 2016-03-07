using System;
using System.Windows.Forms;

namespace AbstractFactoryPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car c = new Car(new BMWCarFactory());
            label1.Text = c.ToString();
            label2.Text = c.Drive();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Car c = new Car(new AudiCarFactory());
            label1.Text = c.ToString();
            label2.Text = c.Drive();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Car c = new Car(new MercedesCarFactory());
            label1.Text = c.ToString();
            label2.Text = c.Drive();
        }
    }
}