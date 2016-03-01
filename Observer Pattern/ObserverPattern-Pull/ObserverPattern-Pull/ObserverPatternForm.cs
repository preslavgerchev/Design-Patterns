using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace ObserverPattern_Pull
{
    public partial class ObserverPatternForm : Form
    {
        private MatchTracker matchTracker;
        private GuestSideScoreObserver guestSideObserver;
        private HomeSideScoreObserver homeSideObserver;
        private MatchDrawObserver drawObserver;

        private bool homeNotified = true;
        private bool guestNotified = true;
        private bool drawNotified = true;

        public ObserverPatternForm()
        {
            InitializeComponent();
            matchTracker = new MatchTracker();

            guestSideObserver = new GuestSideScoreObserver(matchTracker);
            homeSideObserver = new HomeSideScoreObserver(matchTracker);
            drawObserver = new MatchDrawObserver(matchTracker);

            guestSideObserver.OnUpdate = () =>
            {
                label2.Text = guestSideObserver.ToString();
                label7.Text = "Notified!";
                label7.BackColor = Color.Green;
            };
            homeSideObserver.OnUpdate = () =>
            {
                label1.Text = homeSideObserver.ToString();
                label6.Text = "Notified!";
                label6.BackColor = Color.Green;
            };
            drawObserver.OnUpdate = () =>
            {
                label9.Text = drawObserver.ToString();
                label8.Text = "Notified!";
                label8.BackColor = Color.Green;
            };
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
            if (homeNotified)
            {
                matchTracker.RemoveObserver(homeSideObserver);
                homeNotified = false;
                button2.Text = "Subscribe";
            }
            else
            {
                matchTracker.AddObserver(homeSideObserver);
                homeNotified = true;
                button2.Text = "Unsubscribe";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (guestNotified)
            {
                matchTracker.RemoveObserver(guestSideObserver);
                guestNotified = false;
                button3.Text = "Subscribe";
            }
            else
            {
                matchTracker.AddObserver(guestSideObserver);
                guestNotified = true;
                button2.Text = "Unsubscribe";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (drawNotified)
            {
                matchTracker.RemoveObserver(drawObserver);
                drawNotified = false;
                button4.Text = "Subscribe";
            }
            else
            {
                matchTracker.AddObserver(drawObserver);
                drawNotified = true;
                button2.Text = "Unsubscribe";
            }
        }
    }
}