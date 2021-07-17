using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpalCalculator
{
    public partial class Form1 : Form
    {
        string operation = "";
        double resultValue = 0;
        bool is_Operation_Performed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void number_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" || is_Operation_Performed) 
            {
                txtResult.Clear();
            }
            Button btn = (Button)sender;

            if (btn.Text == ".")
            {
                if (!txtResult.Text.Contains("."))
                {
                    txtResult.Text = txtResult.Text + btn.Text;
                }
            }
            else
            {
                txtResult.Text = txtResult.Text + btn.Text;
            }

            is_Operation_Performed = false;
        }

        private void operation_Click(object sender, EventArgs e)
        {
            if (resultValue != 0)
            {
                button18.PerformClick();
                Button btn = (Button)sender;
                operation = btn.Text;
                resultValue = double.Parse(txtResult.Text);
                lblResult.Text = resultValue + operation;
                is_Operation_Performed = true;
            }
            else
            {
                Button btn = (Button)sender;
                operation = btn.Text;
                resultValue = double.Parse(txtResult.Text);
                lblResult.Text = resultValue + operation;
                is_Operation_Performed = true;
            }
            
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            lblResult.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    txtResult.Text=(resultValue + double.Parse(txtResult.Text)).ToString();
                    break;
                case "-":
                    txtResult.Text = (resultValue - double.Parse(txtResult.Text)).ToString();
                    break;
                case "*":
                    txtResult.Text = (resultValue * double.Parse(txtResult.Text)).ToString();
                    break;
                case "/":
                    txtResult.Text = (resultValue / double.Parse(txtResult.Text)).ToString();
                    break;
            }
        }
    }
}
