using System;
using System.Windows.Forms;

namespace AbstractFactoryPattern
{
    public partial class AbstractFactoryForm : Form
    {
        private Car car;

        public AbstractFactoryForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            car = new Car(new BMWCarPartsFactory());
            label1.Text = car.ToString();
            label2.Text = "No information yet!  ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            car = new Car(new AudiCarPartsFactory());
            label1.Text = car.ToString();
            label2.Text = "No information yet!";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            car = new Car(new MercedesCarPartsFactory());
            label1.Text = car.ToString();
            label2.Text = "No information yet!";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = car.Drive();
        }
    }
}