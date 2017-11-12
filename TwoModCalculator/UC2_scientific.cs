using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoModCalculator
{
    public partial class UC2_scientific : UserControl
    {
        public decimal CalculationValue
        {
            get
            {
                return Convert.ToDecimal(result.Text);
            }

            set
            {
                result.Text = value.ToString();
            }
        }

        

        string operation = ""; //none of the operation buttons is clicked yet
        double value = 0;
        bool operation_pressed = false, comma_pressed = false, new_calculation = true;
        bool perform_click_call = false, second_op_first_value;
        string first_operand = "";

        public UC2_scientific()
        {
            InitializeComponent();
        }

        private void result_2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_C_Click(object sender, EventArgs e)
        {
            value = 0;
            operation_pressed = false;
            operation = "";
            result.Text = "0";
            //backgroundCalc.Text = "";
            new_calculation = true;
        }

        private void CEbutton_Click(object sender, EventArgs e)
        {
            if (result.Text.EndsWith(","))
            {
                comma_pressed = false;
            }

            if (result.Text.Count() > 1)
            {
                result.Text = result.Text.Remove(result.Text.Count() - 1);
                if (operation_pressed)
                {
                    //backgroundCalc.Text = backgroundCalc.Text.Remove(backgroundCalc.Text.Count() - 1);
                }
            }

            else if (result.Text.Count() == 1)
            {
                result.Text = "0";
            }
        }

        private void button_ZERO_Click(object sender, EventArgs e)
        {
            if (result.Text != "0")
                result.Text = result.Text + "0";
            if (second_op_first_value == true && result.Text != "0")
            {
                result.Text = "0";
            }
        }

        private void operation_Click(object sender, EventArgs e)
        {
            Button GenericPressedOperation = (Button)sender;
            operation = GenericPressedOperation.Text;
            new_calculation = false;
            value = Double.Parse(result.Text);
            first_operand = result.Text;
            second_op_first_value = true;
            comma_pressed = false;


            if (new_calculation == false && operation_pressed == true)
            {
                perform_click_call = true;
                buttonEqual.PerformClick();

                perform_click_call = false;
            }



            operation_pressed = true;

          
            result.Text = first_operand;
        }

        private void singular_operation_Click(object sender, EventArgs e)
        {
            Button GenericPressedButton = (Button)sender;
            string singular_operation = GenericPressedButton.Text;
            switch( singular_operation )
            {
                case "Sqrt":
                    result.Text = (CalculationOperations.SquareRoot(Double.Parse(result.Text)).ToString());
                    break;
                case "Exp":
                    result.Text = (CalculationOperations.Exp(Double.Parse(result.Text)).ToString());
                    break;
                case "Abs":
                    result.Text = (CalculationOperations.Absolute(Double.Parse(result.Text)).ToString());
                    break;
                case "Tan":
                    result.Text = (CalculationOperations.Tan(Double.Parse(result.Text)).ToString());
                    break;
                case "Sin":
                    result.Text = (CalculationOperations.Sin(Double.Parse(result.Text)).ToString());
                    break;
                case "Cos":
                    result.Text = (CalculationOperations.Cos(Double.Parse(result.Text)).ToString());
                    break;
                default:
                    break;
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    result.Text = CalculationOperations.Sum(value, Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    if (Double.Parse(result.Text) == 0)
                    {
                        MessageBox.Show("ERROR: Can not be divided by 0");
                        value = 0;
                    }
                    else
                    {
                        result.Text = CalculationOperations.Division(value, Double.Parse(result.Text)).ToString();
                    }
                    break;
                case "-":
                    result.Text = CalculationOperations.Subtraction(value, Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = CalculationOperations.Multiplication(value, Double.Parse(result.Text)).ToString();
                    break;
            }
            operation = "";
            operation_pressed = false;
            if (perform_click_call == false)
                //backgroundCalc.Text = "";
            value = Double.Parse(result.Text);
            second_op_first_value = false;
            comma_pressed = false;
        }

        private void backgroundCalc_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button GenericPressedButton = (Button)sender;

            if (result.Text == "0") //clear the initial 0 from the result screen
                result.Clear();

            else if (GenericPressedButton.Text == "," && comma_pressed == true)
                return;

            if (operation_pressed == false)
                result.Text = result.Text + GenericPressedButton.Text;
            else
            {
                if (second_op_first_value == true)
                {
                    result.Text = "";
                    second_op_first_value = false;
                }
                result.Text = result.Text + GenericPressedButton.Text;
            }

            if (result.Text.Contains(",") && GenericPressedButton.Text == "," && new_calculation == true)
            {
                return;
            }


            if (GenericPressedButton.Text == ",")
                comma_pressed = true;

            new_calculation = false;

        }
    }
}
