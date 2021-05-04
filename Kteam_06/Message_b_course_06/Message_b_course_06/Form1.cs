using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Message_b_course_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test ok ");
            
            DialogResult result = MessageBox.Show("Content", "caption", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            //if(result == System.Windows.Forms.DialogResult.Yes)
            ///{
                 
           // }

            switch(result)
            {
                case DialogResult.Yes:
                    MessageBox.Show("yes");
                    break;

                case DialogResult.Cancel:
                    MessageBox.Show("cancel");
                    break;
                default:
                    break;
            }
        }
    }
}
