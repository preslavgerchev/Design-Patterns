using System;
using System.Windows.Forms;

namespace Decorator_Pattern
{
    public partial class DecoratorPatternForm : Form
    {
        IOrder order;
        bool check;

        public DecoratorPatternForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;
            checkBox6.Enabled = false;
            checkBox7.Enabled = false;
            checkBox8.Enabled = false;
            checkBox9.Enabled = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            check = false;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            order = new WhiteBread();
            textBox1.Text = order.Description;
            label1.Text = order.Price.ToString();
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;
            checkBox5.Enabled = true;
            checkBox6.Enabled = true;
            checkBox7.Enabled = true;
            checkBox8.Enabled = true;
            checkBox9.Enabled = true;
            check = true;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            order = new SesameBread();
            textBox1.Text = order.Description;
            label1.Text = order.Price.ToString();
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;
            checkBox5.Enabled = true;
            checkBox6.Enabled = true;
            checkBox7.Enabled = true;
            checkBox8.Enabled = true;
            checkBox9.Enabled = true;
            check = true;
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            order = new BrownBread();
            textBox1.Text = order.Description;
            label1.Text = order.Price.ToString();
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;
            checkBox5.Enabled = true;
            checkBox6.Enabled = true;
            checkBox7.Enabled = true;
            checkBox8.Enabled = true;
            checkBox9.Enabled = true;
            check = true;
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            order = new Ham(order);
            textBox1.Text = order.Description;
            label1.Text = order.Price.ToString();
            checkBox1.Enabled = false;
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            order = new Cheese(order);
            textBox1.Text = order.Description;
            label1.Text = order.Price.ToString();
            checkBox2.Enabled = false;
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            order = new Cabbage(order);
            textBox1.Text = order.Description;
            label1.Text = order.Price.ToString();
            checkBox3.Enabled = false;
        }

        private void checkBox4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            order = new Cucumber(order);
            textBox1.Text = order.Description;
            label1.Text = order.Price.ToString();
            checkBox4.Enabled = false;
        }

        private void checkBox5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            order = new Olives(order);
            textBox1.Text = order.Description;
            label1.Text = order.Price.ToString();
            checkBox5.Enabled = false;
        }

        private void checkBox6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            order = new Pepper(order);
            textBox1.Text = order.Description;
            label1.Text = order.Price.ToString();
            checkBox6.Enabled = false;
        }

        private void checkBox7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            order = new Tomato(order);
            textBox1.Text = order.Description;
            label1.Text = order.Price.ToString();
            checkBox7.Enabled = false;
        }

        private void checkBox8_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            order = new Ketchup(order);
            textBox1.Text = order.Description;
            label1.Text = order.Price.ToString();
            checkBox8.Enabled = false;
        }

        private void checkBox9_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            order = new Mayonnaise(order);
            textBox1.Text = order.Description;
            label1.Text = order.Price.ToString();
            checkBox9.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (check)
            {
                MessageBox.Show("Your order: \n" + order.Description);
                Close();
            }
            else
            { MessageBox.Show("Please, first make an order!"); }

        }
    }
}
