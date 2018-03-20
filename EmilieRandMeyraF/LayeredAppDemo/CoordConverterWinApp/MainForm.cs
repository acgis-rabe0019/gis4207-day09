using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoordConvertersBLL;


namespace CoordConverterWinApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string MDeg = tbxDeg.Text;
            string MMin = tbxMin.Text;
            string MSec = tbxSec.Text;
            string MQuadrant = cboQuandrant.SelectedItem.ToString();
            int deg;
            int min;
            double sec;
            
            deg = int.Parse(MDeg);
            min = int.Parse(MMin);
            sec = double.Parse(MSec);

            

            DMSConverter dms = new DMSConverter();

            DMSCoord Coord = new DMSCoord();
            Coord.deg = deg;
            Coord.min = min;
            Coord.sec = sec;
            Coord.quadrant = (Quadrant) Enum.Parse(typeof(Quadrant),MQuadrant);
                

            lbIDd.Text = dms.Dms2Dd(Coord).ToString();


        }

        private void lbIDd_Click(object sender, EventArgs e)
        {
            
        }
    }
}
