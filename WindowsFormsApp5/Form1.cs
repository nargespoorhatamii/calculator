using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_num1.Text = "";
            txt_num2.Text = "";
            lbl_res.Text = "";
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txt_num1.Text);
            double num2 = Convert.ToDouble(txt_num2.Text);
            double MUL= num1 * num2;
            lbl_res.Text = MUL.ToString();
        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txt_num1.Text);
            double num2 = Convert.ToDouble(txt_num2.Text);
            double sum = num1 + num2;
            lbl_res.Text = sum.ToString();
        }

        private void txt_num1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_num2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txt_num1.Text);
            double num2 = Convert.ToDouble(txt_num2.Text);
            if (num2 > num1)
            {
                double divide = num2 / num1;
                lbl_res.Text = divide.ToString();
            }
            else
            {
                double divide = num1/ num2;
                lbl_res.Text = divide.ToString();
            }
        }

        private void btn_mines_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txt_num1.Text);
            double num2 = Convert.ToDouble(txt_num2.Text);
            if (num1 > num2)
            {
                double MUL = num1 - num2;
                lbl_res.Text = MUL.ToString();
            }
            else
            {
                double MUL = num2 - num1;
                lbl_res.Text = MUL.ToString();
            }
           
        }
    }
}
