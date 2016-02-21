using System;
using System.Linq;
using System.Windows.Forms;

namespace StrategyPattern
{
    public partial class Form1 : Form
    {
        private  Random randomGenerator;
        private bool tru;
        OperatingSystem os;
        public Form1()
        {
            InitializeComponent();
            randomGenerator = new Random();
            os = new OperatingSystem();
            timer1.Interval = 2000;
            for (int i = 0; i < 20; i++)
            {
                int number = randomGenerator.Next(1, 101);
                while (os.Numbers.Contains(number))
                {
                    number = randomGenerator.Next(1, 101);
                }
                os.Numbers.Add(number);
            }
        
            os.Numbers.ForEach(number => listBox1.Items.Add(number));
            var orderedList = os.Numbers.OrderBy(n => n);
            foreach (int i in orderedList)
            {
                listBox2.Items.Add(i);
            }
            os.CurrentNumber = os.Numbers[0];
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tru)
            {
                os.DiskReadingStrategy = new SCANReadingStrategy();
            }
            else
            {
                os.DiskReadingStrategy = new SSTFReadingStrategy();
            }
            tru = !tru;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = os.ReadNumber().ToString();
            os.Numbers.Remove(os.CurrentNumber);
            int number = randomGenerator.Next(1, 101);
            while (os.Numbers.Contains(number))
            {
                number = randomGenerator.Next(1, 101);
            }
            os.Numbers.Add(number);
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