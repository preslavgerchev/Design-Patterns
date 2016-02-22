using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace StrategyPattern
{
    public partial class StrategyPatternForm : Form
    {
        OperatingSystem os;
        public StrategyPatternForm()
        {
            InitializeComponent();
            os = new OperatingSystem(new FCFSSchedulerStrategy());
            timer1.Interval = 1000;
            os.Numbers.ForEach(number => lbRandomNumbers.Items.Add(number));
            var orderedList = os.Numbers.OrderBy(n => n);
            foreach (int i in orderedList)
            {
                lbOrderedNumbers.Items.Add(i);
            }
            btnStop.Enabled = false;
            tbCurrent.Font = new Font(tbCurrent.Font.FontFamily, 20);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tbCurrent.Text = os.NextNumber().ToString();
            trackBar1.Value = os.CurrentNumber;
            progressBar1.Value = os.CurrentNumber;
            os.Numbers.Remove(os.CurrentNumber);
            os.PopulateNumbersList();
            lbRandomNumbers.Items.Clear();
            for (int i = 0; i < os.Numbers.Count; i++)
            {
                lbRandomNumbers.Items.Add(os.Numbers.ElementAt(i));
            }
            lbOrderedNumbers.Items.Clear();
            var orderedList = os.Numbers.OrderBy(n => n);
            foreach (int i in orderedList)
            {
                lbOrderedNumbers.Items.Add(i);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void rbFCFS_MouseClick(object sender, MouseEventArgs e)
        {
            os.DiskReadingStrategy = new FCFSSchedulerStrategy();
        }

        private void rbSSTF_MouseClick(object sender, MouseEventArgs e)
        {
            os.DiskReadingStrategy = new SSTFSchedulerStrategy();
        }

        private void rbSCAN_MouseClick(object sender, MouseEventArgs e)
        {
            os.DiskReadingStrategy = new SCANSchedulerStrategy();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }
    }
}