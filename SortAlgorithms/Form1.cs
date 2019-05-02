using Algotithm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortAlgorithms
{
    public partial class Form1 : Form
    {
        AlgorithmBase<int> algotithm = new BubbleSort<int>();

        public Form1()
        {
            InitializeComponent();
        }       

        private void button1_Click(object sender, EventArgs e)
        {
            if(int.TryParse(textBox1.Text, out int value))
            {
                algotithm.Items.Add(value);
                label1.Text += " " + value;
            }
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            algotithm.Sort();
            foreach (var item in algotithm.Items)
            {
                label2.Text += " " + item;
            }
        }
    }
}
