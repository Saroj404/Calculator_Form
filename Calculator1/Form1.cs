using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class form1 : Form
    {
        double resultvalue = 0;
        string operationperformed = "";
        bool isoperationperformed = false;

        public form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textbox_result.Text == "0")||isoperationperformed)
                textbox_result.Clear();
            isoperationperformed = false;
            Button button = (Button)sender;
            if(button.Text==".")
            {
                if(!textbox_result.Text.Contains("."))
                {
                    textbox_result.Text = textbox_result.Text + button.Text;
                }
                
            }
            else
            textbox_result.Text = textbox_result.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationperformed = button.Text;
            resultvalue = Double.Parse(textbox_result.Text);
            labelcurrentoperation.Text = resultvalue + " "+operationperformed;
            isoperationperformed = true;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            textbox_result.Text = "0";
            
            

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textbox_result.Text = "0";
            resultvalue = 0;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            switch (operationperformed)
            {
                case "+":
                    textbox_result.Text = (resultvalue + Double.Parse(textbox_result.Text)).ToString();
                    break;
                case "-":
                    textbox_result.Text = (resultvalue - Double.Parse(textbox_result.Text)).ToString();
                    break;
                case "*":
                    textbox_result.Text = (resultvalue * Double.Parse(textbox_result.Text)).ToString();
                    break;
                case "/":
                    textbox_result.Text = (resultvalue /Double.Parse(textbox_result.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultvalue = Double.Parse(textbox_result.Text);
            labelcurrentoperation.Text = " ";

        }
    }
}
