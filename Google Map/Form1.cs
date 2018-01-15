using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Google_Map
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string street = txt_Street.Text;
            string city = txt_City.Text;
            string state = txt_State.Text;
            string zip = txt_Zip.Text;
            try
            {
                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("https://www.google.com/maps?q=");
                if(street!= string.Empty)
                {
                    queryaddress.Append(street + "," + "+");
                }
                if (city != string.Empty)
                {
                    queryaddress.Append(city + "," + "+");
                }
                if (state != string.Empty)
                {
                    queryaddress.Append(state + "," + "+");
                }
                if (zip != string.Empty)
                {
                    queryaddress.Append(zip + "," + "+");
                }
                webBrowser1.Navigate(queryaddress.ToString());

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
