using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kteam_course_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            loadLabel();
        }


        void loadLabel()
        {
            Label lb = new Label();
            lb.Text = "how kteam ";
            this.Controls.Add(lb);

            lb.BackColor = Color.Aqua;
        }

        /****************************************** FORM AND LABEL **********************************************/
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label1.Text = "free education...";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = " shre to be better";

            // show form 2
            Form2 t = new Form2();
            t.Show();
            // t.ShowDialog();
            t.f2_label1.Text = " better and better ";
            //t.f2_label1.Show();
        }


        /****************************************** BUTTON SECTION **********************************************/
        int i = 0;
        void addButton()
        {

            Random rand = new Random();
            Button btn = new Button() { Text = i.ToString(), Location = new Point(rand.Next(0, this.Size.Width), rand.Next(0,this.Size.Height))};
            // create event
            //btn.Click += btn_Click;
            //btn.Text = i.ToString();

            this.Controls.Add(btn);

            i++; 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addButton();
        }

        private void btnValue_Click(object sender, EventArgs e)
        {
            //lbValue.Text = txbValue.Text;
            //lbValue = Convert.ToInt32(txbValue.Text);
            //lbValue.Text = (numb * numb).ToString();
            int numb = 0;
            if (Int32.TryParse(txbValue.Text, out numb))
                lbValue.Text = (numb*numb).ToString();
            else
                MessageBox.Show("please inter number");
            

        }

        private void txbValue_TextChanged(object sender, EventArgs e)
        {
            int numb = 0;
            if (Int32.TryParse(txbValue.Text, out numb))
                lbValue.Text = (numb * numb).ToString();
            else
                MessageBox.Show("please inter number");
        }


        /************************************* CHECKBOX SECTION *******************************/

        private void checkBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("check changed");
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            MessageBox.Show("check state changed");
        }



        private void btnEnter_Click(object sender, EventArgs e)
        {

            string name = txbName.Text;
            string kter = ckbKter.CheckState == CheckState.Checked ? " are " : ckbKter.CheckState == CheckState.Unchecked ? " are not " : "three state";
            string showString = string.Format("hello {0}, you {1} Kter", name, kter);

            lbNameKter.Text = showString;

        }

        /***************************************************************************************************************/
    }
}
