namespace MVP_Test
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
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.labCoast = new System.Windows.Forms.Label();
            this.btnCoast = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            this.SuspendLayout();
            // 
            // numCount
            // 
            this.numCount.Location = new System.Drawing.Point(165, 33);
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(120, 23);
            this.numCount.TabIndex = 0;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(35, 32);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 23);
            this.txtPrice.TabIndex = 1;
            // 
            // labCoast
            // 
            this.labCoast.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labCoast.Location = new System.Drawing.Point(35, 88);
            this.labCoast.Name = "labCoast";
            this.labCoast.Size = new System.Drawing.Size(100, 23);
            this.labCoast.TabIndex = 2;
            // 
            // btnCoast
            // 
            this.btnCoast.Location = new System.Drawing.Point(165, 92);
            this.btnCoast.Name = "btnCoast";
            this.btnCoast.Size = new System.Drawing.Size(120, 23);
            this.btnCoast.TabIndex = 3;
            this.btnCoast.Text = "Coast";
            this.btnCoast.UseVisualStyleBackColor = true;
            this.btnCoast.Click += new System.EventHandler(this.btnCoast_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 168);
            this.Controls.Add(this.btnCoast);
            this.Controls.Add(this.labCoast);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.numCount);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label labCoast;
        private System.Windows.Forms.Button btnCoast;
    }
}
