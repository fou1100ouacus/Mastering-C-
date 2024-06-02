namespace Event
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
            this.ctrlCalclator1 = new Event.ctrlCalclator();
            this.SuspendLayout();
            // 
            // ctrlCalclator1
            // 
            this.ctrlCalclator1.Location = new System.Drawing.Point(70, 24);
            this.ctrlCalclator1.Name = "ctrlCalclator1";
            this.ctrlCalclator1.Size = new System.Drawing.Size(238, 148);
            this.ctrlCalclator1.TabIndex = 0;
            this.ctrlCalclator1.OnCalculationComplete += new System.Action<int>(this.ctrlCalclator1_OnCalculationComplete);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 251);
            this.Controls.Add(this.ctrlCalclator1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlCalclator ctrlCalclator1;
    }
}

