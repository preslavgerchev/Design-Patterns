using System;
using System.Windows.Forms;

namespace Builder_Pattern
{
    public partial class BuilderForm : Form
    {
        private CarConstructor carConstructor;

        public BuilderForm()
        {
            InitializeComponent();
            label1.Text = "";
            carConstructor = new CarConstructor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ICarBuilder bmwBuilder = new BMWBuilder();
            carConstructor.Construct(bmwBuilder);
            label1.Text = bmwBuilder.Car.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ICarBuilder audiBuilder = new AudiBuilder();
            carConstructor.Construct(audiBuilder);
            label1.Text = audiBuilder.Car.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ICarBuilder mercedesBuilder = new MercedesBuilder();
            carConstructor.Construct(mercedesBuilder);
            label1.Text = mercedesBuilder.Car.ToString();
        }
    }
}