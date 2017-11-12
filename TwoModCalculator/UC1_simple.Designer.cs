namespace TwoModCalculator
{
    partial class UC1_simple
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.result = new System.Windows.Forms.TextBox();
            this.button_C = new System.Windows.Forms.Button();
            this.CEbutton = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.button_ADDITION = new System.Windows.Forms.Button();
            this.button_SUBTRACTION = new System.Windows.Forms.Button();
            this.button_MULTIPLICATION = new System.Windows.Forms.Button();
            this.button_DIVISION = new System.Windows.Forms.Button();
            this.button_COMMA = new System.Windows.Forms.Button();
            this.button_ZERO = new System.Windows.Forms.Button();
            this.button_NINE = new System.Windows.Forms.Button();
            this.button_EIGHT = new System.Windows.Forms.Button();
            this.button_SEVEN = new System.Windows.Forms.Button();
            this.button_SIX = new System.Windows.Forms.Button();
            this.button_FIVE = new System.Windows.Forms.Button();
            this.button_FOUR = new System.Windows.Forms.Button();
            this.button_THREE = new System.Windows.Forms.Button();
            this.button_TWO = new System.Windows.Forms.Button();
            this.button_ONE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.result.Location = new System.Drawing.Point(5, 32);
            this.result.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(304, 42);
            this.result.TabIndex = 38;
            this.result.TabStop = false;
            this.result.Text = "0";
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // button_C
            // 
            this.button_C.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_C.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_C.Location = new System.Drawing.Point(251, 154);
            this.button_C.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_C.Name = "button_C";
            this.button_C.Size = new System.Drawing.Size(56, 66);
            this.button_C.TabIndex = 37;
            this.button_C.TabStop = false;
            this.button_C.Text = "C";
            this.button_C.UseVisualStyleBackColor = false;
            this.button_C.Click += new System.EventHandler(this.button_C_Click);
            // 
            // CEbutton
            // 
            this.CEbutton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CEbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CEbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CEbutton.Location = new System.Drawing.Point(251, 81);
            this.CEbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CEbutton.Name = "CEbutton";
            this.CEbutton.Size = new System.Drawing.Size(56, 66);
            this.CEbutton.TabIndex = 36;
            this.CEbutton.TabStop = false;
            this.CEbutton.Text = "CE";
            this.CEbutton.UseVisualStyleBackColor = false;
            this.CEbutton.Click += new System.EventHandler(this.CEbutton_Click);
            // 
            // buttonEqual
            // 
            this.buttonEqual.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEqual.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEqual.ForeColor = System.Drawing.Color.Black;
            this.buttonEqual.Location = new System.Drawing.Point(251, 226);
            this.buttonEqual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(57, 140);
            this.buttonEqual.TabIndex = 35;
            this.buttonEqual.TabStop = false;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = false;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // button_ADDITION
            // 
            this.button_ADDITION.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_ADDITION.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_ADDITION.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_ADDITION.Location = new System.Drawing.Point(189, 300);
            this.button_ADDITION.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_ADDITION.Name = "button_ADDITION";
            this.button_ADDITION.Size = new System.Drawing.Size(56, 66);
            this.button_ADDITION.TabIndex = 34;
            this.button_ADDITION.TabStop = false;
            this.button_ADDITION.Text = "+";
            this.button_ADDITION.UseVisualStyleBackColor = false;
            this.button_ADDITION.Click += new System.EventHandler(this.operation_Click);
            // 
            // button_SUBTRACTION
            // 
            this.button_SUBTRACTION.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_SUBTRACTION.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_SUBTRACTION.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_SUBTRACTION.Location = new System.Drawing.Point(189, 226);
            this.button_SUBTRACTION.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_SUBTRACTION.Name = "button_SUBTRACTION";
            this.button_SUBTRACTION.Size = new System.Drawing.Size(56, 66);
            this.button_SUBTRACTION.TabIndex = 33;
            this.button_SUBTRACTION.TabStop = false;
            this.button_SUBTRACTION.Text = "-";
            this.button_SUBTRACTION.UseVisualStyleBackColor = false;
            this.button_SUBTRACTION.Click += new System.EventHandler(this.operation_Click);
            // 
            // button_MULTIPLICATION
            // 
            this.button_MULTIPLICATION.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_MULTIPLICATION.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_MULTIPLICATION.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_MULTIPLICATION.Location = new System.Drawing.Point(189, 154);
            this.button_MULTIPLICATION.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_MULTIPLICATION.Name = "button_MULTIPLICATION";
            this.button_MULTIPLICATION.Size = new System.Drawing.Size(56, 66);
            this.button_MULTIPLICATION.TabIndex = 32;
            this.button_MULTIPLICATION.TabStop = false;
            this.button_MULTIPLICATION.Text = "*";
            this.button_MULTIPLICATION.UseVisualStyleBackColor = false;
            this.button_MULTIPLICATION.Click += new System.EventHandler(this.operation_Click);
            // 
            // button_DIVISION
            // 
            this.button_DIVISION.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_DIVISION.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_DIVISION.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_DIVISION.Location = new System.Drawing.Point(189, 81);
            this.button_DIVISION.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_DIVISION.Name = "button_DIVISION";
            this.button_DIVISION.Size = new System.Drawing.Size(56, 66);
            this.button_DIVISION.TabIndex = 31;
            this.button_DIVISION.TabStop = false;
            this.button_DIVISION.Text = "/";
            this.button_DIVISION.UseVisualStyleBackColor = false;
            this.button_DIVISION.Click += new System.EventHandler(this.operation_Click);
            // 
            // button_COMMA
            // 
            this.button_COMMA.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_COMMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_COMMA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_COMMA.Location = new System.Drawing.Point(127, 300);
            this.button_COMMA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_COMMA.Name = "button_COMMA";
            this.button_COMMA.Size = new System.Drawing.Size(56, 66);
            this.button_COMMA.TabIndex = 30;
            this.button_COMMA.TabStop = false;
            this.button_COMMA.Text = ",";
            this.button_COMMA.UseVisualStyleBackColor = false;
            this.button_COMMA.Click += new System.EventHandler(this.button_Click);
            // 
            // button_ZERO
            // 
            this.button_ZERO.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_ZERO.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_ZERO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_ZERO.Location = new System.Drawing.Point(3, 300);
            this.button_ZERO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_ZERO.Name = "button_ZERO";
            this.button_ZERO.Size = new System.Drawing.Size(117, 66);
            this.button_ZERO.TabIndex = 29;
            this.button_ZERO.TabStop = false;
            this.button_ZERO.Text = "0";
            this.button_ZERO.UseVisualStyleBackColor = false;
            this.button_ZERO.Click += new System.EventHandler(this.button_ZERO_Click);
            // 
            // button_NINE
            // 
            this.button_NINE.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_NINE.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_NINE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_NINE.Location = new System.Drawing.Point(127, 226);
            this.button_NINE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_NINE.Name = "button_NINE";
            this.button_NINE.Size = new System.Drawing.Size(56, 66);
            this.button_NINE.TabIndex = 28;
            this.button_NINE.TabStop = false;
            this.button_NINE.Text = "9";
            this.button_NINE.UseVisualStyleBackColor = false;
            this.button_NINE.Click += new System.EventHandler(this.button_Click);
            // 
            // button_EIGHT
            // 
            this.button_EIGHT.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_EIGHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_EIGHT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_EIGHT.Location = new System.Drawing.Point(65, 226);
            this.button_EIGHT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_EIGHT.Name = "button_EIGHT";
            this.button_EIGHT.Size = new System.Drawing.Size(56, 66);
            this.button_EIGHT.TabIndex = 27;
            this.button_EIGHT.TabStop = false;
            this.button_EIGHT.Text = "8";
            this.button_EIGHT.UseVisualStyleBackColor = false;
            this.button_EIGHT.Click += new System.EventHandler(this.button_Click);
            // 
            // button_SEVEN
            // 
            this.button_SEVEN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_SEVEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_SEVEN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_SEVEN.Location = new System.Drawing.Point(3, 226);
            this.button_SEVEN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_SEVEN.Name = "button_SEVEN";
            this.button_SEVEN.Size = new System.Drawing.Size(56, 66);
            this.button_SEVEN.TabIndex = 26;
            this.button_SEVEN.TabStop = false;
            this.button_SEVEN.Text = "7";
            this.button_SEVEN.UseVisualStyleBackColor = false;
            this.button_SEVEN.Click += new System.EventHandler(this.button_Click);
            // 
            // button_SIX
            // 
            this.button_SIX.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_SIX.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_SIX.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_SIX.Location = new System.Drawing.Point(127, 154);
            this.button_SIX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_SIX.Name = "button_SIX";
            this.button_SIX.Size = new System.Drawing.Size(56, 66);
            this.button_SIX.TabIndex = 25;
            this.button_SIX.TabStop = false;
            this.button_SIX.Text = "6";
            this.button_SIX.UseVisualStyleBackColor = false;
            this.button_SIX.Click += new System.EventHandler(this.button_Click);
            // 
            // button_FIVE
            // 
            this.button_FIVE.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_FIVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_FIVE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_FIVE.Location = new System.Drawing.Point(65, 154);
            this.button_FIVE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_FIVE.Name = "button_FIVE";
            this.button_FIVE.Size = new System.Drawing.Size(56, 66);
            this.button_FIVE.TabIndex = 24;
            this.button_FIVE.TabStop = false;
            this.button_FIVE.Text = "5";
            this.button_FIVE.UseVisualStyleBackColor = false;
            this.button_FIVE.Click += new System.EventHandler(this.button_Click);
            // 
            // button_FOUR
            // 
            this.button_FOUR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_FOUR.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_FOUR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_FOUR.Location = new System.Drawing.Point(3, 154);
            this.button_FOUR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_FOUR.Name = "button_FOUR";
            this.button_FOUR.Size = new System.Drawing.Size(56, 66);
            this.button_FOUR.TabIndex = 23;
            this.button_FOUR.TabStop = false;
            this.button_FOUR.Text = "4";
            this.button_FOUR.UseVisualStyleBackColor = false;
            this.button_FOUR.Click += new System.EventHandler(this.button_Click);
            // 
            // button_THREE
            // 
            this.button_THREE.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_THREE.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_THREE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_THREE.Location = new System.Drawing.Point(127, 81);
            this.button_THREE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_THREE.Name = "button_THREE";
            this.button_THREE.Size = new System.Drawing.Size(56, 66);
            this.button_THREE.TabIndex = 22;
            this.button_THREE.TabStop = false;
            this.button_THREE.Text = "3";
            this.button_THREE.UseVisualStyleBackColor = false;
            this.button_THREE.Click += new System.EventHandler(this.button_Click);
            // 
            // button_TWO
            // 
            this.button_TWO.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_TWO.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_TWO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_TWO.Location = new System.Drawing.Point(65, 81);
            this.button_TWO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_TWO.Name = "button_TWO";
            this.button_TWO.Size = new System.Drawing.Size(56, 66);
            this.button_TWO.TabIndex = 21;
            this.button_TWO.TabStop = false;
            this.button_TWO.Text = "2";
            this.button_TWO.UseVisualStyleBackColor = false;
            this.button_TWO.Click += new System.EventHandler(this.button_Click);
            // 
            // button_ONE
            // 
            this.button_ONE.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_ONE.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_ONE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_ONE.Location = new System.Drawing.Point(3, 81);
            this.button_ONE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_ONE.Name = "button_ONE";
            this.button_ONE.Size = new System.Drawing.Size(56, 66);
            this.button_ONE.TabIndex = 20;
            this.button_ONE.TabStop = false;
            this.button_ONE.Text = "1";
            this.button_ONE.UseVisualStyleBackColor = false;
            this.button_ONE.Click += new System.EventHandler(this.button_Click);
            // 
            // UC1_simple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Controls.Add(this.result);
            this.Controls.Add(this.button_C);
            this.Controls.Add(this.CEbutton);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.button_ADDITION);
            this.Controls.Add(this.button_SUBTRACTION);
            this.Controls.Add(this.button_MULTIPLICATION);
            this.Controls.Add(this.button_DIVISION);
            this.Controls.Add(this.button_COMMA);
            this.Controls.Add(this.button_ZERO);
            this.Controls.Add(this.button_NINE);
            this.Controls.Add(this.button_EIGHT);
            this.Controls.Add(this.button_SEVEN);
            this.Controls.Add(this.button_SIX);
            this.Controls.Add(this.button_FIVE);
            this.Controls.Add(this.button_FOUR);
            this.Controls.Add(this.button_THREE);
            this.Controls.Add(this.button_TWO);
            this.Controls.Add(this.button_ONE);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC1_simple";
            this.Size = new System.Drawing.Size(313, 370);
            this.Load += new System.EventHandler(this.UC1_simple_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UC1_simple_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_C;
        private System.Windows.Forms.Button CEbutton;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button button_ADDITION;
        private System.Windows.Forms.Button button_SUBTRACTION;
        private System.Windows.Forms.Button button_MULTIPLICATION;
        private System.Windows.Forms.Button button_DIVISION;
        private System.Windows.Forms.Button button_COMMA;
        private System.Windows.Forms.Button button_ZERO;
        private System.Windows.Forms.Button button_NINE;
        private System.Windows.Forms.Button button_EIGHT;
        private System.Windows.Forms.Button button_SEVEN;
        private System.Windows.Forms.Button button_SIX;
        private System.Windows.Forms.Button button_FIVE;
        private System.Windows.Forms.Button button_FOUR;
        private System.Windows.Forms.Button button_THREE;
        private System.Windows.Forms.Button button_TWO;
        private System.Windows.Forms.Button button_ONE;
        public System.Windows.Forms.TextBox result;
    }
}
