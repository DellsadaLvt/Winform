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
