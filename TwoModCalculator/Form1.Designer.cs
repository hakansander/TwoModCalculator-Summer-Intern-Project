namespace TwoModCalculator
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.uC1_simple1 = new TwoModCalculator.UC1_simple();
            this.ModChange = new System.Windows.Forms.Button();
            this.uC2_scientific1 = new TwoModCalculator.UC2_scientific();
            this.SuspendLayout();
            // 
            // uC1_simple1
            // 
            this.uC1_simple1.Location = new System.Drawing.Point(-3, 2);
            this.uC1_simple1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC1_simple1.Name = "uC1_simple1";
            this.uC1_simple1.Size = new System.Drawing.Size(313, 370);
            this.uC1_simple1.TabIndex = 0;
            this.uC1_simple1.Load += new System.EventHandler(this.uC1_simple1_Load_1);
            // 
            // ModChange
            // 
            this.ModChange.Location = new System.Drawing.Point(12, 2);
            this.ModChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ModChange.Name = "ModChange";
            this.ModChange.Size = new System.Drawing.Size(112, 31);
            this.ModChange.TabIndex = 1;
            this.ModChange.Text = "ModChange";
            this.ModChange.UseVisualStyleBackColor = true;
            this.ModChange.Click += new System.EventHandler(this.ModChange_Click);
            // 
            // uC2_scientific1
            // 
            this.uC2_scientific1.Location = new System.Drawing.Point(-3, 2);
            this.uC2_scientific1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC2_scientific1.Name = "uC2_scientific1";
            this.uC2_scientific1.Size = new System.Drawing.Size(455, 370);
            this.uC2_scientific1.TabIndex = 2;
            this.uC2_scientific1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 372);
            this.Controls.Add(this.ModChange);
            this.Controls.Add(this.uC1_simple1);
            this.Controls.Add(this.uC2_scientific1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UC1_simple uC1_simple1;
        private System.Windows.Forms.Button ModChange;
        private UC2_scientific uC2_scientific1;
    }
}

