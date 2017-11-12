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
    public partial class UC1_simple : UserControl
    {
        public decimal CalculationValue {
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

        public UC1_simple()
        {
            InitializeComponent();
        }

        private void UC1_simple_Load(object sender, EventArgs e)
        {

        }

        private void result_TextChanged(object sender, EventArgs e)
        {

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

            if( result.Text.Contains(",") && GenericPressedButton.Text == "," && new_calculation == true )
            {
                return;
            }


            if (GenericPressedButton.Text == ",")
                comma_pressed = true;

            new_calculation = false;

        }


        private void button_ONE_Click(object sender, EventArgs e)
        {

        }

        private void button_TWO_Click(object sender, EventArgs e)
        {

        }

        private void button_DIVISION_Click(object sender, EventArgs e)
        {

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

        private void UC1_simple_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "ENTER":
                    buttonEqual.PerformClick();
                    break;
                case "1":
                    button_ONE.PerformClick();
                    break;
                case "2":
                    button_TWO.PerformClick();
                    break;
                case "3":
                    button_THREE.PerformClick();
                    break;
                case "4":
                    button_FOUR.PerformClick();
                    break;
                case "5":
                    button_FIVE.PerformClick();
                    break;
                case "6":
                    button_SIX.PerformClick();
                    break;
                case "7":
                    button_SEVEN.PerformClick();
                    break;
                case "8":
                    button_EIGHT.PerformClick();
                    break;
                case "9":
                    button_NINE.PerformClick();
                    break;
                case "0":
                    button_ZERO.PerformClick();
                    break;
                case "/":
                    button_DIVISION.PerformClick();
                    break;
                case "*":
                    button_MULTIPLICATION.PerformClick();
                    break;
                case "+":
                    button_ADDITION.PerformClick();
                    break;
                case "-":
                    button_SUBTRACTION.PerformClick();
                    break;
                case ",":
                    button_COMMA.PerformClick();
                    break;
                default:
                    break;
            }

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
            if( second_op_first_value == true && result.Text != "0" )
            {
                result.Text = "0";
            }
        }
    }
}
