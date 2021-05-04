using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pannel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Text = "how kteam";
            btn.AutoSize = true;


            /********** PANEL ****************/
            /*Random rand = new Random();
            btn.Location = new Point(rand.Next(0, pnlButton.Size.Width), rand.Next(0, pnlButton.Size.Height));
            pnlButton.Controls.Add(btn);

            /*********** FLOW LAYOUT PANEL **********/
            fpnlButton.Controls.Add(btn);

           
            
             
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlButton.Enabled = !pnlButton.Enabled;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
