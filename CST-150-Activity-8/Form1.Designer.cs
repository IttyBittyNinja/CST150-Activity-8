namespace CST_150_Activity_8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.carbInput = new System.Windows.Forms.TextBox();
            this.fatInput = new System.Windows.Forms.TextBox();
            this.fatCalc = new System.Windows.Forms.Button();
            this.carbCalc = new System.Windows.Forms.Button();
            this.fatOutput = new System.Windows.Forms.TextBox();
            this.carbOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fat Grams:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carbs Grams:";
            // 
            // carbInput
            // 
            this.carbInput.Location = new System.Drawing.Point(95, 43);
            this.carbInput.Name = "carbInput";
            this.carbInput.Size = new System.Drawing.Size(100, 23);
            this.carbInput.TabIndex = 2;
            // 
            // fatInput
            // 
            this.fatInput.Location = new System.Drawing.Point(95, 6);
            this.fatInput.Name = "fatInput";
            this.fatInput.Size = new System.Drawing.Size(100, 23);
            this.fatInput.TabIndex = 3;
            // 
            // fatCalc
            // 
            this.fatCalc.Location = new System.Drawing.Point(201, 6);
            this.fatCalc.Name = "fatCalc";
            this.fatCalc.Size = new System.Drawing.Size(173, 23);
            this.fatCalc.TabIndex = 4;
            this.fatCalc.Text = "Calculate Calories From Fat";
            this.fatCalc.UseVisualStyleBackColor = true;
            this.fatCalc.Click += new System.EventHandler(this.fatCalc_Click);
            // 
            // carbCalc
            // 
            this.carbCalc.Location = new System.Drawing.Point(201, 42);
            this.carbCalc.Name = "carbCalc";
            this.carbCalc.Size = new System.Drawing.Size(173, 23);
            this.carbCalc.TabIndex = 5;
            this.carbCalc.Text = "Calculate Calories From Carbs";
            this.carbCalc.UseVisualStyleBackColor = true;
            this.carbCalc.Click += new System.EventHandler(this.carbCalc_Click);
            // 
            // fatOutput
            // 
            this.fatOutput.Enabled = false;
            this.fatOutput.Location = new System.Drawing.Point(380, 7);
            this.fatOutput.Name = "fatOutput";
            this.fatOutput.Size = new System.Drawing.Size(100, 23);
            this.fatOutput.TabIndex = 6;
            // 
            // carbOutput
            // 
            this.carbOutput.Enabled = false;
            this.carbOutput.Location = new System.Drawing.Point(380, 43);
            this.carbOutput.Name = "carbOutput";
            this.carbOutput.Size = new System.Drawing.Size(100, 23);
            this.carbOutput.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 69);
            this.Controls.Add(this.carbOutput);
            this.Controls.Add(this.fatOutput);
            this.Controls.Add(this.carbCalc);
            this.Controls.Add(this.fatCalc);
            this.Controls.Add(this.fatInput);
            this.Controls.Add(this.carbInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calorie Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox carbInput;
        private TextBox fatInput;
        private Button fatCalc;
        private Button carbCalc;
        private TextBox fatOutput;
        private TextBox carbOutput;
    }
}