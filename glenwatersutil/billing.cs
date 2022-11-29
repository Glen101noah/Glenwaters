using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace glenwatersutil
{
    public partial class billing : Form
    {

         Form1 frm = new Form1();

        


        public billing()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Totalbtn_Click(object sender, EventArgs e)
        {
            double dbTotal = 0;

            if (Akl.Checked && du.Checked && dw.Checked && taxrb.Checked)
            {
                dbTotal = Convert.ToDouble(3.60 + 0.65);
            }
            else if (Bkl.Checked && du.Checked && dw.Checked && taxrb.Checked)
            {
                dbTotal = Convert.ToDouble(13.43 + 3.36);
            }
            else if (Ckl.Checked && du.Checked && dw.Checked && taxrb.Checked)
            {
                dbTotal = Convert.ToDouble(23.51 + 5.03);
            }
            else if (Dkl.Checked && du.Checked && dw.Checked && taxrb.Checked)
            {
                dbTotal = Convert.ToDouble(36.16 + 6.71);
            }
            else if (Ekl.Checked && du.Checked && dw.Checked && taxrb.Checked)
            {
                dbTotal = Convert.ToDouble(45.21 * 8.39);
            }

            // Household --No TAX

            if (Akl.Checked && du.Checked && dw.Checked == true)
            {
                dbTotal = Convert.ToDouble(3.60 + 0.65);
            }
            else if (Bkl.Checked && du.Checked && dw.Checked == true)
            {
                dbTotal = Convert.ToDouble(11.78 + 2.95);
            }
            else if (Ckl.Checked && du.Checked && dw.Checked == true)
            {
                dbTotal = Convert.ToDouble(20.62 + 4.41);
            }
            else if (Dkl.Checked && du.Checked && dw.Checked == true)
            {
                dbTotal = Convert.ToDouble(31.72 + 5.89);
            }
            else if (Ekl.Checked && du.Checked && dw.Checked == true)
            {
                dbTotal = Convert.ToDouble(39.66 + 7.36);
            }




            //For the second usages- commercial --With Tax

            else if (Akl.Checked && cu.Checked && cw.Checked && taxrb.Checked == true)
            {
                dbTotal = Convert.ToDouble(4.92 + 0.74);
            }
            else if (Bkl.Checked && cu.Checked && cw.Checked && taxrb.Checked == true)
            {
                dbTotal = Convert.ToDouble(14.61 + 3.36);
            }
            else if (Ckl.Checked && cu.Checked && cw.Checked && taxrb.Checked == true)
            {
                dbTotal = Convert.ToDouble(25.58 + 5.03);
            }
            else if (Dkl.Checked && cu.Checked && cw.Checked && taxrb.Checked == true)
            {
                dbTotal = Convert.ToDouble(39.35 + 6.71);
            }
            else if (Ekl.Checked && cu.Checked && cw.Checked && taxrb.Checked == true)
            {
                dbTotal = Convert.ToDouble(49.20 + 8.39);
            }

            //For the second usages- commercial --With NO TAX

            else if (Akl.Checked && cu.Checked && cw.Checked == true)
            {
                dbTotal = Convert.ToDouble(4.32 + 0.65);
            }
            else if (Bkl.Checked && cu.Checked && cw.Checked == true)
            {
                dbTotal = Convert.ToDouble(12.82 + 2.95);
            }
            else if (Ckl.Checked && cu.Checked && cw.Checked == true)
            {
                dbTotal = Convert.ToDouble(22.44 + 4.41);
            }
            else if (Dkl.Checked && cu.Checked && cw.Checked == true)
            {
                dbTotal = Convert.ToDouble(34.52 + 5.89);
            }
            else if (Ekl.Checked && cu.Checked && cw.Checked ==  true)
            {
                dbTotal = Convert.ToDouble(43.16 + 7.36);
            }
            
               lblTotal.Text = dbTotal.ToString("0.00");

            


            

          



        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblTotal.Text = "";
            Akl.Checked = false;
            Bkl.Checked = false;
            Ckl.Checked = false;
            Dkl.Checked = false;
            Ekl.Checked = false;
            cw.Checked = false;
            cu.Checked = false;
            du.Checked = false;
            dw.Checked = false;
            taxrb.Checked = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }
    }
}
