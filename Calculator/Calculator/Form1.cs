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
    public partial class Form1 : Form
    {
        ICalculate myCal;
        public Form1()
        {
            InitializeComponent();
            myCal = new Calculate();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtNum1.Value == 0)
            {
                MessageBox.Show("Please enter the first number.");
            }
            else
            {
                if(txtNum2.Value == 0)
                {
                    MessageBox.Show("Please enter the second number.");
                }
                else
                {
                    switch (listBox.Text)
                    {
                        case "Add":
                            int sum = myCal.Add((int)txtNum1.Value, (int)txtNum2.Value);
                            MessageBox.Show($"Sum is equal to {sum}");
                            break;
                        case "Multiply":
                            int multiple = myCal.Multiply((int)txtNum1.Value, (int)txtNum2.Value);
                            MessageBox.Show($"Multiply is equal to {multiple}");
                            break;
                        case "Minus":
                            int minus = myCal.Minus((int)txtNum1.Value, (int)txtNum2.Value);
                            MessageBox.Show($"Minus is equal to {minus}");
                            break;
                        case "Divide":
                            double devide = (double) myCal.Divide((int)txtNum1.Value, (int)txtNum2.Value);
                            MessageBox.Show($"Divide is equal to {devide}");
                            break;
                    }
                }
            }
        }
    }
}
