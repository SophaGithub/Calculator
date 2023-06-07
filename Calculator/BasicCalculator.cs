using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class BasicCalculator : Form
    {
        double FirstNumber;
        double SecondNumber;
        double Result;
        string Operation;
        public BasicCalculator()
        {
            InitializeComponent();
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            if(txtBox1.Text == "0" && txtBox1 != null)
            {
                txtBox1.Text= "1";
            }
            else
            {
                txtBox1.Text = txtBox1.Text + "1";
            }
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text == "0" && txtBox1 != null)
            {
                txtBox1.Text = "2";
            }
            else
            {
                txtBox1.Text = txtBox1.Text + "2";
            }
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text == "0" && txtBox1 != null)
            {
                txtBox1.Text = "3";
            }
            else
            {
                txtBox1.Text = txtBox1.Text + "3";
            }
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text == "0" && txtBox1 != null)
            {
                txtBox1.Text = "4";
            }
            else
            {
                txtBox1.Text = txtBox1.Text + "4";
            }
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text == "0" && txtBox1 != null)
            {
                txtBox1.Text = "5";
            }
            else
            {
                txtBox1.Text = txtBox1.Text + "5";
            }
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text == "0" && txtBox1 != null)
            {
                txtBox1.Text = "6";
            }
            else
            {
                txtBox1.Text = txtBox1.Text + "6";
            }
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text == "0" && txtBox1 != null)
            {
                txtBox1.Text = "7";
            }
            else
            {
                txtBox1.Text = txtBox1.Text + "7";
            }
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text == "0" && txtBox1 != null)
            {
                txtBox1.Text = "8";
            }
            else
            {
                txtBox1.Text = txtBox1.Text + "8";
            }
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text == "0" && txtBox1 != null)
            {
                txtBox1.Text = "9";
            }
            else
            {
                txtBox1.Text = txtBox1.Text + "9";
            }
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            txtBox1.Text = txtBox1.Text + "0";
            
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtBox1.Text);
            txtBox1.Text = "0";
            Operation = "+";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtBox1.Text);
            txtBox1.Text = "0";
            Operation = "-";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtBox1.Text);
            txtBox1.Text = "0";
            Operation = "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtBox1.Text);
            txtBox1.Text = "0";
            Operation = "/";
        }
        private void btnMod_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtBox1.Text);
            txtBox1.Text = "0";
            Operation = "%";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBox1.Text = "";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtBox1.Text = txtBox1.Text + ".";
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            SecondNumber= Convert.ToDouble(txtBox1.Text);

            if(Operation=="+")
            {
                Result =(FirstNumber + SecondNumber);
                txtBox1.Text= Convert.ToString(Result);
                FirstNumber = Result;
            }
            if(Operation=="-")
            {
                Result = (FirstNumber - SecondNumber);
                txtBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if(Operation=="*")
            {
                Result = (FirstNumber * SecondNumber);
                txtBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if(Operation== "/")
            {
                if (SecondNumber == 0)
                {
                    txtBox1.Text = "connot divide by zero";
                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    txtBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
            if (Operation == "%")
            {
                Result = (FirstNumber % SecondNumber);
                txtBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
        }

        
    }
}
