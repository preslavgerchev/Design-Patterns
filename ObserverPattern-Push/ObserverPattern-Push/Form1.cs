using System;
using System.Drawing;
using System.Windows.Forms;


namespace ObserverPattern_Push
{
    public partial class Form1 : Form
    {
        private MatchTracker matchTracker;
        private MatchObserver fifaMatchObserver;
        private MatchObserver uefaMatchObserver;
        private MatchObserver ourOwnMatchObserver;

        private bool fifaNotified = true;
        private bool uefaNotified = true;
        private bool ourNotified = true;

        public Form1()
        {
            InitializeComponent();
            matchTracker = new MatchTracker();
            matchTracker.GuestSideScore = 2;
            matchTracker.HomeSideScore = 3;
            fifaMatchObserver = new MatchObserver(matchTracker, "FIFA Match Observer");
            uefaMatchObserver = new MatchObserver(matchTracker, "UEFA Match Observer");
            ourOwnMatchObserver = new MatchObserver(matchTracker, "Our own Match Observer");

            fifaMatchObserver.OnUpdate = () =>
            {
                label10.Text = fifaMatchObserver.ToString();
                label11.Text = "Notified!";
                label11.BackColor = Color.Green;
            };
            uefaMatchObserver.OnUpdate = () =>
            {
                label6.Text = uefaMatchObserver.ToString();
                label7.Text = "Notified!";
                label7.BackColor = Color.Green;
            };
            ourOwnMatchObserver.OnUpdate = () =>
            {
                label9.Text = ourOwnMatchObserver.ToString();
                label8.Text = "Notified!";
                label8.BackColor = Color.Green;
            };

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (fifaNotified)
            {
                matchTracker.RemoveObserver(fifaMatchObserver);
                fifaNotified = false;
                button2.Text = "Subscribe";
            }
            else
            {
                matchTracker.AddObserver(fifaMatchObserver);
                fifaNotified = true;
                button2.Text = "Unsubscribe";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (uefaNotified)
            {
                matchTracker.RemoveObserver(uefaMatchObserver);
                uefaNotified = false;
                button3.Text = "Subscribe";
            }
            else
            {
                matchTracker.AddObserver(uefaMatchObserver);
                uefaNotified = true;
                button3.Text = "Unsubscribe";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ourNotified)
            {
                matchTracker.RemoveObserver(ourOwnMatchObserver);
                ourNotified = false;
                button4.Text = "Subscribe";
            }
            else
            {
                matchTracker.AddObserver(ourOwnMatchObserver);
                ourNotified = true;
                button4.Text = "Unsubscribe";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label7.Text = "";
            label8.Text = "";
            label11.Text = "";
            int homeSideScore = int.Parse(textBox4.Text);
            int guestSideScore = int.Parse(textBox5.Text);
            matchTracker.UpdateScore(homeSideScore, guestSideScore);
        }
    }
}