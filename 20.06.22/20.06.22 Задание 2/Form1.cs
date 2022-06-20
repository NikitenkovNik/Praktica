using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20._06._22_Задание_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long x = Convert.ToInt32(textBox1.Text);
            textBox2.Text = Convert.ToString(Factorial(x));
        }
        long Factorial(long n)
        {
            if (n == 1) return 1;

            return n * Factorial(n - 1);
        }
    }
}
