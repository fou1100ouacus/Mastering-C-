namespace SimpleEventWithParametersUsingArguments
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
            this.ctrlCalculate1 = new SimpleEventWithParametersUsingArguments.ctrlCalculate();
            this.SuspendLayout();
            // 
            // ctrlCalculate1
            // 
            this.ctrlCalculate1.Location = new System.Drawing.Point(46, 28);
            this.ctrlCalculate1.Name = "ctrlCalculate1";
            this.ctrlCalculate1.Size = new System.Drawing.Size(255, 188);
            this.ctrlCalculate1.TabIndex = 0;
            this.ctrlCalculate1.OnCalculationComplete += new System.EventHandler<SimpleEventWithParametersUsingArguments.ctrlCalculate.CalculationCompleteEventArgs>(this.ctrlCalculate1_OnCalculationComplete);
            this.ctrlCalculate1.Load += new System.EventHandler(this.ctrlCalculate1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 244);
            this.Controls.Add(this.ctrlCalculate1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlCalculate ctrlCalculate1;
    }
}

