using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decorator_Pattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IOrder order = new SesameBread();
            order = new Ham(order);
            order = new Ketchup(order);
            order = new Tomato(order);
            textBox1.Text = order.Description;
            textBox2.Text = order.Price.ToString();
        }
    }
}
