using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adapter_Pattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IDigitalSignalTransmitter digitalTransmitter = new AnalogToDigitalAdapter(new AnalogTransmitter());
            label1.Text = digitalTransmitter.TransmitDigitalData("Beep beep");
        }
    }
}
