using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace latihan_1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(label2.Text);
            int b = Convert.ToInt32(label1.Text);


            vScrollBar1.Minimum = 0;
            vScrollBar1.Maximum = 19;
            vScrollBar2.Minimum = 0;
            vScrollBar2.Maximum = 19;
            vScrollBar2.Value = 10;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Text = vScrollBar1.Value.ToString();
            dateTimePicker1.MaxDate = DateTime.Today.AddYears(vScrollBar1.Value);
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            label2.Text = vScrollBar2.Value.ToString();
            dateTimePicker1.MinDate = DateTime.Today.AddYears(-vScrollBar2.Value);
        }
    }
}
