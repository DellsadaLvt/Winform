/*************************************************************************************************/

/*************** COURSE 03 ***************/
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


        /***************** BUTTON SECTION ***************/
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


        /************** CHECKBOX SECTION ***************/

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


/******************************************************************/

/*************** COURSE 06 ***************/
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

/*********************** PANEL *******************************/
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

/***************** RADIO BUTTON ***********************/
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
    }
}
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;

            if(radio.Checked)
            {
                label1.Text = radio.Text;
            }
        }

/******************* [10] COMBOBOX ****************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboboxGui
{
    public partial class Form1 : Form
    {
        List<string> listItem;
        List<food> listItem_01;
        List<food> listItem_02;
        List<CBClass> listClass;
        public Form1()
        {
            InitializeComponent();
            /********************/
            listItem_02 = new List<food>() {
            new food() { Name="sup cua", Price= 500} ,
            new food() { Name="tom hum", Price= 600} ,
            new food() { Name="sui cao", Price= 800} ,
        };
            comboBox2.DataSource = listItem_02;
            comboBox2.DisplayMember = "Name";
            //AddBinding();
            /********************/
            listClass = new List<CBClass>();
            listClass.Add(new CBClass()
            {
                ClassName = "12A1",
                ListStudent = new List<string>() {"K1", "K2" }
            });
            listClass.Add(new CBClass()
            {
                ClassName = "12A2",
                ListStudent = new List<string>() { "K3", "K4" }
            });

            cbBranch.DataSource = listClass;
            cbBranch.DisplayMember = "ClassName";

            AddClassBinding();
            /********************/

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Index Changed");
            ComboBox cb = sender as ComboBox;
            MessageBox.Show(cb.SelectedIndex.ToString());
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Value Changed");
            ComboBox cb = sender as ComboBox;
            MessageBox.Show(cb.SelectedItem.ToString());
        }

  
        private void button1_Click(object sender, EventArgs e)
        {
            listItem = new List<string>() { "howKtem.com", "Fre Education", "share to be better" };
            comboBox4.DataSource = listItem;
            listItem_01 = new List<food>() {
            new food() { Name="sup cua", Price= 500} ,
            new food() { Name="tom hum", Price= 600} ,
            new food() { Name="sui cao", Price= 800} ,
        };
            comboBox5.DataSource = listItem_01;
            comboBox5.DisplayMember = "Name";

            comboBox6.DataSource = listItem_01;
            comboBox6.DisplayMember = "Price";
        }

        public class food
        {
            public string Name { get; set; }
            public float Price { get; set; }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        /*void AddBinding()
        {
            // get the value of Price in the datasource of combobox2, then insert into the "Text" property of Textbox1
            //textBox1.DataBindings.Add(new Binding("Text", comboBox2.DataSource, "Price"));
            
        }*/

        void AddClassBinding()
        {
            cbClass.DataBindings.Add("DataSource", cbBranch.SelectedValue, "ListStudent");
        }

            

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cbb = sender as ComboBox;

            if(cbb.SelectedValue != null)
            {
                food foods = cbb.SelectedValue as food;
                textBox1.Text = foods.Price.ToString();

            }
        }

        public class CBClass
        {
            public string ClassName { get; set; }
            public List<string> ListStudent { get; set; }
        }

        private void cbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbBranch_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if(cb.SelectedValue != null)
            {
                CBClass cl = cb.SelectedValue as CBClass;
                cbClass.DataSource = cl.ListStudent;
            }
        }
    }
}
/******************* [11] IMAGE ****************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LoadImageName();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            // copy Resource folder into bin/debug
            pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Resources\\AdobeStock_79790508-825x510.jpeg");
        }

        

        void LoadImageName()
        {
            List<string> ListImage = new List<string>() {
                "2020-12-03 223717" ,
                "a"};
            cbImage.DataSource = ListImage;
        }

        string extention = ".jpg";
        private void cbImage_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if( cb.SelectedValue != null)
            {
                Bitmap bm = new Bitmap(Application.StartupPath + "\\Resources\\" +
                                        cb.SelectedValue.ToString() + extention);
                pcbImage.Image = bm;
            }
        }
    }
}
