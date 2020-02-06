namespace Future_Value
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMonthlyInvestment = new System.Windows.Forms.TextBox();
            this.txtYearlyInterestRate = new System.Windows.Forms.TextBox();
            this.txtNumberOfYears = new System.Windows.Forms.TextBox();
            this.txtFutureValue = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monthly Investment:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yearly interest Rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of Years:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Future Value:";
            // 
            // txtMonthlyInvestment
            // 
            this.txtMonthlyInvestment.Location = new System.Drawing.Point(329, 74);
            this.txtMonthlyInvestment.Name = "txtMonthlyInvestment";
            this.txtMonthlyInvestment.Size = new System.Drawing.Size(100, 24);
            this.txtMonthlyInvestment.TabIndex = 4;
            // 
            // txtYearlyInterestRate
            // 
            this.txtYearlyInterestRate.Location = new System.Drawing.Point(329, 144);
            this.txtYearlyInterestRate.Name = "txtYearlyInterestRate";
            this.txtYearlyInterestRate.Size = new System.Drawing.Size(100, 24);
            this.txtYearlyInterestRate.TabIndex = 5;
            // 
            // txtNumberOfYears
            // 
            this.txtNumberOfYears.Location = new System.Drawing.Point(329, 214);
            this.txtNumberOfYears.Name = "txtNumberOfYears";
            this.txtNumberOfYears.Size = new System.Drawing.Size(100, 24);
            this.txtNumberOfYears.TabIndex = 6;
            this.txtNumberOfYears.TextChanged += new System.EventHandler(this.txtNumberOfYears_TextChanged);
            // 
            // txtFutureValue
            // 
            this.txtFutureValue.Location = new System.Drawing.Point(329, 275);
            this.txtFutureValue.Name = "txtFutureValue";
            this.txtFutureValue.ReadOnly = true;
            this.txtFutureValue.Size = new System.Drawing.Size(100, 24);
            this.txtFutureValue.TabIndex = 7;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(99, 381);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(122, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(281, 380);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 506);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtFutureValue);
            this.Controls.Add(this.txtNumberOfYears);
            this.Controls.Add(this.txtYearlyInterestRate);
            this.Controls.Add(this.txtMonthlyInvestment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Future Value";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMonthlyInvestment;
        private System.Windows.Forms.TextBox txtYearlyInterestRate;
        private System.Windows.Forms.TextBox txtNumberOfYears;
        private System.Windows.Forms.TextBox txtFutureValue;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

