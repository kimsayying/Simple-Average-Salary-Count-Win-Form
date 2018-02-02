using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                double average;
                double input1 = double.Parse(txtinput1.Text);
                double input2 = double.Parse(txtInput2.Text);

                average = (input1 + input2) / 2;
                msgLabel.BackColor = Color.Azure;

                // Currency globalization
                // This code- (sets currency to RM(Malaysia) then prints a line.)
                // :C has the effect of formatting average value as currency, the default value is $(USD).
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-MY", false);
                msgLabel.Text = $"Average Salary: {average:C}";
            }

            catch
            {
                Match match = Regex.Match(txtinput1.Text, "^[a-zA-Z]*$");
                Match match2 = Regex.Match(txtInput2.Text, "^[a-zA-Z]*$");
               
                if (txtinput1.Text == "" ||txtInput2.Text == "" || match.Success == true ||match2.Success == true)
                {
                    msgLabel.BackColor = Color.Red;
                    msgLabel.Text = "Please enter a valid integer.";
                }
            }

        }

        private void msgLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
