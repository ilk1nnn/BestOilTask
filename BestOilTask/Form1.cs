using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOilTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(guna2ComboBox1.SelectedIndex == 0)
            {
                oil_price.Text = "1.50 man";
                priceofoillbl.Visible = true;
                countofoillbl.Visible = true;
                litr.Visible = true;
                guna2Button1.Visible = true;
            }
            if(guna2ComboBox1.SelectedIndex == 1)
            {
                oil_price.Text = "2.50 man";
                priceofoillbl.Visible = true;
                countofoillbl.Visible = true;
                litr.Visible = true;
                guna2Button1.Visible = true;
            }
            if (guna2ComboBox1.SelectedIndex == 2)
            {
                oil_price.Text = "0.50 man";
                priceofoillbl.Visible = true;
                countofoillbl.Visible = true;
                litr.Visible = true;
                guna2Button1.Visible = true;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(guna2ComboBox1.SelectedIndex == 0)
            {

                double totalforgas = 1.5 * (int.Parse(litr.Text));
                paymentlbl.Visible = true;
                paymentforgas.Visible = true;
                paymentforgas.Text = totalforgas.ToString();
                total.Text = paymentforgas.Text;
            }
            if (guna2ComboBox1.SelectedIndex == 1)
            {

                double totalforgas = 2.5 * (int.Parse(litr.Text));
                paymentlbl.Visible = true;
                paymentforgas.Visible = true;
                paymentforgas.Text = totalforgas.ToString();
                total.Text = paymentforgas.Text;

            }
            if (guna2ComboBox1.SelectedIndex == 2)
            {

                double totalforgas = 0.5 * (int.Parse(litr.Text));
                paymentlbl.Visible = true;
                paymentforgas.Visible = true;
                paymentforgas.Text = totalforgas.ToString();
                total.Text = paymentforgas.Text;

            }
        }

        private void hotdog_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            hotdog_pricelbl.Visible = true;
        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            hamburger_pricelbl.Visible=true;
        }

        private void guna2CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            cola_pricelbl.Visible = true;
        }

        private void pay_btn_Click(object sender, EventArgs e)
        {
            if(hotdogmask.Text == String.Empty)
            {
                hotdogmask.Text = "0";
            }
            if(hamburgermask.Text == String.Empty)
            {
                hamburgermask.Text = "0";
            }
            if (colamask.Text == String.Empty)
            {
                colamask.Text = "0";
            }
            double totalcafe = 2 * (int.Parse(hotdogmask.Text)) + 2.5 * (int.Parse(hamburgermask.Text)) + 1.5 * (int.Parse(colamask.Text));
            forminicafe.Text = totalcafe.ToString();
            if(paymentforgas.Text == String.Empty)
            {

                total.Text = forminicafe.Text;
            }
            else
            {
                double total2 = totalcafe + double.Parse(paymentforgas.Text);
                total.Text = total2.ToString();

            }
        }

        private void total_Click(object sender, EventArgs e)
        {
            
        }

        private void paytotal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulations!");
        }
    }
}
