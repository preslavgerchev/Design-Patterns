using System;
using System.Linq;
using System.Windows.Forms;

namespace StrategyPattern
{
    public partial class Form1 : Form
    {
       
        private bool tru;
        OperatingSystem os;
        public Form1()
        {
            InitializeComponent();
            os = new OperatingSystem(new FCFSSchedulerStrategy());
            timer1.Interval = 1000;
            os.Numbers.ForEach(number => listBox1.Items.Add(number));
            var orderedList = os.Numbers.OrderBy(n => n);
            foreach (int i in orderedList)
            {
                listBox2.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tru)
            {
                os.DiskReadingStrategy = new SCANSchedulerStrategy();
            }
            else
            {
                os.DiskReadingStrategy = new SSTFSchedulerStrategy();
            }
            tru = !tru;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = os.ReadNumber().ToString();
            trackBar1.Value = os.CurrentNumber;
            os.Numbers.Remove(os.CurrentNumber);
            os.PopulateNumbersList();
            listBox1.Items.Clear();
            for (int i = 0; i < os.Numbers.Count; i++)
            {
                listBox1.Items.Add(os.Numbers.ElementAt(i));
            }
            listBox2.Items.Clear();
            var orderedList = os.Numbers.OrderBy(n => n);
            foreach (int i in orderedList)
            {
                listBox2.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}