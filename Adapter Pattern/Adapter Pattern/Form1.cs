using System;
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
            IAnalogSignalTransmitter analogTrasmitter = new AnalogTransmitter();
            label1.Text = analogTrasmitter.TransmitAnalogData("beep");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IDigitalSignalTransmitter digitalTransmitter = new DigitalTransmitter();
            label1.Text = digitalTransmitter.TransmitDigitalData("beep");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IDigitalSignalTransmitter analogToDigitalAdapter = new AnalogToDigitalAdapter(new AnalogTransmitter());
            label1.Text = analogToDigitalAdapter.TransmitDigitalData("beep");
        }
    }
}