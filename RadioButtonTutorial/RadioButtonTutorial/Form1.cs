using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonTutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void ShowResult(Label lb, Panel pnl)
        {
            RadioButton rdb = null;
            foreach( RadioButton item in pnl.Controls)
            {
                if( item != null)
                    if( item.Checked)
                    {
                        rdb = item;
                        break;
                    }
            }
            if( rdb != null )
            {
                lb.Text = rdb.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowResult(label1, pnl1);
            ShowResult(label2, pnl2);
            ShowResult(label2, pnl3);

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;

            if(radio.Checked)
            {
                label1.Text = radio.Text;
            }
        }
    }
}
