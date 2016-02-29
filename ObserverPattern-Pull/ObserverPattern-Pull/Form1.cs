using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverPattern_Pull
{
    public partial class Form1 : Form
    {
        private MatchTracker matchTracker;
        private GuestSideScoreObserver guestSideObserver;
        private HomeSideScoreObserver homeSideObserver;
        private MatchDrawObserver drawObserver;

        public Form1()
        {
            InitializeComponent();
            matchTracker = new MatchTracker();

            guestSideObserver = new GuestSideScoreObserver(matchTracker);
            homeSideObserver = new HomeSideScoreObserver(matchTracker);
            drawObserver = new MatchDrawObserver(matchTracker);

            guestSideObserver.OnUpdate = () =>
            {
                textBox2.Text = guestSideObserver.ToString();
                label7.Text = "Notified!";
                label7.BackColor = Color.Green;
            };
            homeSideObserver.OnUpdate = () =>
            {
                textBox1.Text = homeSideObserver.ToString();
                label6.Text = "Notified!";
                label6.BackColor = Color.Green;
            };
            drawObserver.OnUpdate = () =>
            {
                textBox3.Text = drawObserver.ToString();
                label8.Text = "Notified!";
                label8.BackColor = Color.Green;
            }
            ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            int homeSideScore = int.Parse(textBox4.Text);
            int guestSideScore = int.Parse(textBox5.Text);
            matchTracker.UpdateScore(homeSideScore, guestSideScore);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            matchTracker.RemoveObserver(homeSideObserver);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            matchTracker.RemoveObserver(guestSideObserver);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            matchTracker.RemoveObserver(drawObserver);
        }
    }
}