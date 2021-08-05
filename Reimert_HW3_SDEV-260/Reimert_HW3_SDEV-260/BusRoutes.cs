using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reimert_HW3_SDEV_260
{
    public partial class BusRoutes : Form
    {
        public BusRoutes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string streetNumber = textBox1.Text;
            string streetName = textBox1.Text;
            string city = textBox2.Text;
            string state = textBox3.Text;
            string zipcode = textBox3.Text;

            StringBuilder location = new StringBuilder("http://maps.google.com/maps?q=110+Norwood+Street+Mont+Clare+PA+19453");             //("http://maps.google.com/maps?q=");

            ////if (streetNumber !=" "){
            ////    location.Append(streetNumber +  " +");
            ////}
            //if (streetName != " ")
            //{
            //    location.Append(streetName + "," + " +");
            //}
            //if (city !=" "){
            //    location.Append(city + "," + "+");
            //}
            //if (state !=" "){
            //    location.Append(state + "," + "+");
            //}
            //if (zipcode != " ")
            //{
            //    location.Append(zipcode + "," + "+");
            //}

            webBrowser1.Navigate("https://www.google.com/maps/dir/240+N+Gulph+Rd+King+of+Prussia+PA+19406/110+Norwood+St,+Mont+Clare,+PA+19453");
            //("http://maps.google.com/maps?q=110+Norwood+Street+Mont+Clare+PA+19453&output=embed");
        }
    }
    
}
