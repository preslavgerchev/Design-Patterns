using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrategyPattern
{
    public partial class Form1 : Form
    {
        private static Random randomGenerator;
        OperatingSystem os;
        public Form1()
        {
            InitializeComponent();
            randomGenerator = new Random();
            os = new OperatingSystem();
            for (int i = 0; i < 20; i++)
            {
                os.Numbers.Add(randomGenerator.Next(1, 101));
            }
            os.Numbers.ForEach(number => listBox1.Items.Add(number));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = os.ReadNumber();
            label1.Text = number.ToString();
            os.CurrentPosition = number;
            listBox1.Items.Clear();
            for (int i = 0; i < os.Numbers.Count; i++)
            {
                listBox1.Items.Add(os.Numbers.ElementAt(i));
            }
        }
    }
}