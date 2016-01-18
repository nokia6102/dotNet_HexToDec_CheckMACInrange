using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MACmathS;

namespace testMACmath
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MACmath ck = new MACmath();
            if (ck.InRnage(textBox1.Text, textBox2.Text, textBox3.Text))
            {
                label1.Text = "In Rnage";
            }
            else
            {
                label1.Text = "Not In Rnage";
            }
        }
    }
}
