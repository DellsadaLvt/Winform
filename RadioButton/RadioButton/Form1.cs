using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void showResult(Label lb , Panel pnl)
        {
            RadioButton ckb = null;

            foreach( RadioButton item in pnl.Controls)
            {
                if(item != null)
                if(item.Checked)
                {
                    ckb = item;
                    break;
                }
            }

            if (ckb != null)
                lb.Text = ckb.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showResult(label1, pnl1);
            showResult(label2, pnl2);
            showResult(label3, pnl3);
        }
    }
}
