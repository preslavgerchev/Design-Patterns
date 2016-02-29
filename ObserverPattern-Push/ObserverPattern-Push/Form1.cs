using System;
using System.Windows.Forms;

namespace ObserverPattern_Push
{
    public partial class Form1 : Form
    {
        private MatchTracker matchTracker;
        private MatchObserver fifaMatchObserver;
        private MatchObserver uefaMatchObserver;
        private MatchObserver ourOwnMatchObserver;

        public Form1()
        {
            InitializeComponent();
            matchTracker = new MatchTracker();
            matchTracker.GuestSideScore = 2;
            matchTracker.HomeSideScore = 3;
            fifaMatchObserver = new MatchObserver(matchTracker, "FIFA Match Observer");
            uefaMatchObserver = new MatchObserver(matchTracker, "UEFA Match Observer");
            ourOwnMatchObserver = new MatchObserver(matchTracker, "Our own Match Observer");
            fifaMatchObserver.OnUpdate = () => textBox1.Text = fifaMatchObserver.ToString();
            uefaMatchObserver.OnUpdate = () => textBox2.Text = uefaMatchObserver.ToString();
            ourOwnMatchObserver.OnUpdate = () => textBox3.Text = ourOwnMatchObserver.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int homeSideScore = int.Parse(textBox4.Text);
            int guestSideScore = int.Parse(textBox5.Text);
            matchTracker.UpdateScore(homeSideScore, guestSideScore);
        }
    }
}