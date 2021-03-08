using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int soucet = x + y;
            int rozdil = x - y;
            double soucin = x * y;
            double podil = x / y;
            MessageBox.Show(soucet.ToString());
            label1.Text = soucet.ToString();
            MessageBox.Show(rozdil.ToString());
            label2.Text = rozdil.ToString();
            MessageBox.Show(soucin.ToString());
            label3.Text = soucin.ToString();
            MessageBox.Show(podil.ToString());
            label4.Text = podil.ToString();
        }
    }
}
