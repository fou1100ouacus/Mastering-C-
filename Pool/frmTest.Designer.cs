namespace _8Pool
{
    partial class frmTest
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
            this.poolTable1 = new _8Pool.PoolTable();
            this.SuspendLayout();
            // 
            // poolTable1
            // 
            this.poolTable1.BackColor = System.Drawing.Color.Black;
            this.poolTable1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.poolTable1.HourlyRate = 10F;
            this.poolTable1.Location = new System.Drawing.Point(12, 35);
            this.poolTable1.Name = "poolTable1";
            this.poolTable1.Size = new System.Drawing.Size(390, 276);
            this.poolTable1.TabIndex = 0;
            this.poolTable1.TablePlayer = "Player";
            this.poolTable1.TableTitle = "Table";
            this.poolTable1.OnTableComplete += new System.EventHandler<_8Pool.PoolTable.TableCompletedEventArgs>(this.poolTable1_OnTableComplete);
            this.poolTable1.Load += new System.EventHandler(this.poolTable1_Load);
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.poolTable1);
            this.Name = "frmTest";
            this.Text = "frmTest";
            this.Load += new System.EventHandler(this.frmTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private PoolTable poolTable1;
    }
}