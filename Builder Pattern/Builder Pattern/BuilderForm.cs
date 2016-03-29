using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Builder_Pattern
{
    public partial class BuilderForm : Form
    {
        private ICarBuilder bmwBuilder;
        private ICarBuilder audiBuilder;
        private ICarBuilder mercedesBuilder;
        private CarConstructor carConstructor;

        public BuilderForm()
        {
            InitializeComponent();
            carConstructor = new CarConstructor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bmwBuilder = new BMWBuilder();
            carConstructor.Construct(bmwBuilder);
            label1.Text = bmwBuilder.Car.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            audiBuilder = new AudiBuilder();
            carConstructor.Construct(audiBuilder);
            label1.Text = audiBuilder.Car.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mercedesBuilder = new MercedesBuilder();
            carConstructor.Construct(mercedesBuilder);
            label1.Text = mercedesBuilder.Car.ToString();
        }
    }
}