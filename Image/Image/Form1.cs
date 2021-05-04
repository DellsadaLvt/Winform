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
