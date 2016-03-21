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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                IAnalogSignalTransmitter AS = new AnalogTransmitter();
                label1.Text = AS.TransmitAnalogData(textBox1.Text);
            }
            else
            {
                label1.Text = "You need to write some information.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                IDigitalSignalTransmitter DS = new DigitalTransmitter();
                label1.Text = DS.TransmitDigitalData(textBox1.Text);
            }
            else
            {
                label1.Text = "You need to write some information.";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                IDigitalSignalTransmitter digitalTransmitter = new AnalogToDigitalAdapter(new AnalogTransmitter());
                label1.Text = digitalTransmitter.TransmitDigitalData(textBox1.Text);
            }
            else
            {
                label1.Text = "You need to write some information.";
            }
        }
    }
}
