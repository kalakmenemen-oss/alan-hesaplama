using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yenproje2_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            { 
            { üçgen.Visible = true; }
        }

            else
            {
                { üçgen.Visible = false; }
                
            }
        }





        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                { daire.Visible = true; }
                { textBox6.Visible = true; }
                { label7.Visible = true; }
                { label2.Visible = true; }
            }

            else
            {
                { daire.Visible = false; }
                { textBox6.Visible = false; }
                { label7.Visible = true; }
                { label2.Visible = true; }

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                { dikdörtgen.Visible = true; }

            }

            else
            {
                { dikdörtgen.Visible = false; }

            }
        }

        private void daire_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void üçgen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dikdörtgen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                üçgen.Visible = true;
                {
                    double yükseklik = Convert.ToDouble(textBox4.Text);
                    double kenar = Convert.ToDouble(textBox5.Text);
                    double alan1 = (yükseklik * kenar) / 2;
                    MessageBox.Show("üçgen alanı = " + alan1.ToString());
                }
                
            }
            if (radioButton3.Checked == true)
            {
                dikdörtgen.Visible = true;
                { 
                double uzun_knr = Convert.ToDouble(textBox3.Text);
                double kısa_knr = Convert.ToDouble(textBox2.Text);
                double alan2 = uzun_knr * kısa_knr;
                MessageBox.Show("üçgen alanı = " + alan2.ToString());
                }
                
            }
            if (radioButton2.Checked == true)
            {
                daire.Visible = true;
                { 
                double yrp = Convert.ToDouble(textBox6.Text);
                double yarıcp = 3.14 * yrp * yrp;
                MessageBox.Show("dairenin alanı = " + yarıcp.ToString());
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
