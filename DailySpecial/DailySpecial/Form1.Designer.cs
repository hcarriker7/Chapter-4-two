namespace DailySpecial
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
            this.lblSpecial = new System.Windows.Forms.Label();
            this.lblExample = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.btnSpecial = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSpecial
            // 
            this.lblSpecial.AutoSize = true;
            this.lblSpecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSpecial.Location = new System.Drawing.Point(235, 28);
            this.lblSpecial.Name = "lblSpecial";
            this.lblSpecial.Size = new System.Drawing.Size(276, 20);
            this.lblSpecial.TabIndex = 0;
            this.lblSpecial.Text = "Enter a day number to see our special";
            // 
            // lblExample
            // 
            this.lblExample.AutoSize = true;
            this.lblExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblExample.Location = new System.Drawing.Point(278, 69);
            this.lblExample.Name = "lblExample";
            this.lblExample.Size = new System.Drawing.Size(184, 20);
            this.lblExample.TabIndex = 1;
            this.lblExample.Text = "For example, Sunday = 1";
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(345, 108);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(55, 20);
            this.txtDay.TabIndex = 2;
            // 
            // btnSpecial
            // 
            this.btnSpecial.Location = new System.Drawing.Point(335, 143);
            this.btnSpecial.Name = "btnSpecial";
            this.btnSpecial.Size = new System.Drawing.Size(76, 24);
            this.btnSpecial.TabIndex = 3;
            this.btnSpecial.Text = "Get Special";
            this.btnSpecial.UseVisualStyleBackColor = true;
            this.btnSpecial.Click += new System.EventHandler(this.btnSpecial_Click);
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(300, 179);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(150, 51);
            this.lblResult.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 253);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnSpecial);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.lblExample);
            this.Controls.Add(this.lblSpecial);
            this.Name = "Form1";
            this.Text = "Special";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSpecial;
        private System.Windows.Forms.Label lblExample;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Button btnSpecial;
        private System.Windows.Forms.Label lblResult;
    }
}

