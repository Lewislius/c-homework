using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment1
{
    public partial class Form1 : Form
    {
        public double finalResult;

        public Form1()
        {
            InitializeComponent();
        }

        
        private void add_Click(object sender, EventArgs e)
        {
            calOpcode.Text = "+";
            finalResult = double.Parse(number1.Text) + double.Parse(number2.Text); 
        }

        private void sub_Click(object sender, EventArgs e)
        {
            calOpcode.Text = "-";
            finalResult = double.Parse(number1.Text) - double.Parse(number2.Text);
        }

        private void multi_Click(object sender, EventArgs e)
        {
            calOpcode.Text = "×";
            finalResult = double.Parse(number1.Text) * double.Parse(number2.Text);
        }

        private void divide_Click(object sender, EventArgs e)
        {
            calOpcode.Text = "÷";
            finalResult = double.Parse(number1.Text) / double.Parse(number2.Text);
        }

        private void calculate_Click(object sender, EventArgs e)
        {   
            if(calOpcode.Text== "÷" && number2.Text == "0")
            {
                result.Text = "输入错误,除法中除数不能为0";
            }
            else
            {
                result.Text = finalResult.ToString();
            } 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void number1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void number2_TextChanged(object sender, EventArgs e)
        {

        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void calOpcode_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
