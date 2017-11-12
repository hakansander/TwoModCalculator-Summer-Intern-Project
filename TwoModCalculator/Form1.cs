using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoModCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetAutoSizeMode();
        }

        private void ModChange_Click(object sender, EventArgs e)
        {
            
            uC1_simple1.Visible = !uC1_simple1.Visible;
            uC2_scientific1.Visible = !uC2_scientific1.Visible;

            if (uC1_simple1.Visible)
            {
                uC1_simple1.CalculationValue = uC2_scientific1.CalculationValue;
                //uC1_simple1.backgroundText = uC2_scientific1.backgroundText;
            }
            else //UC2_scientific1 will be visible to the user
            {
                uC2_scientific1.CalculationValue = uC1_simple1.CalculationValue;
                //uC2_scientific1.backgroundText = uC1_simple1.backgroundText;
            }
         
            SetAutoSizeMode();
        }

        private void SetAutoSizeMode()
        {
            if (uC1_simple1.Visible)
            {
                this.Width = uC1_simple1.Width + 15;
                this.Height = uC1_simple1.Height + 40;
            }
            else
            if (uC2_scientific1.Visible)
            {
                this.Width = uC2_scientific1.Width + 15;
                this.Height = uC2_scientific1.Height + 40;
            }
        }

        private void uC1_simple1_Load(object sender, EventArgs e)
        {

        }

        private void uC1_simple1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
