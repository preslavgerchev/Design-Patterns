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
        public BuilderForm()
        {
            InitializeComponent();
            ICarBuilder bmwBuilder = new BMWBuilder();
            CarConstructor carConstructor = new CarConstructor();
            carConstructor.Construct(bmwBuilder);
            label1.Text = bmwBuilder.Car.ToString();
        }
    }
}