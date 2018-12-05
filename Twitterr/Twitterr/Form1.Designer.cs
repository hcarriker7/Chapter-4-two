namespace Twitterr
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
            this.txtTwitter = new System.Windows.Forms.TextBox();
            this.lblCounter = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPosted = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTwitter
            // 
            this.txtTwitter.Location = new System.Drawing.Point(266, 12);
            this.txtTwitter.Multiline = true;
            this.txtTwitter.Name = "txtTwitter";
            this.txtTwitter.Size = new System.Drawing.Size(224, 107);
            this.txtTwitter.TabIndex = 0;
            // 
            // lblCounter
            // 
            this.lblCounter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCounter.Location = new System.Drawing.Point(269, 144);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(209, 27);
            this.lblCounter.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Location = new System.Drawing.Point(321, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Post";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPosted
            // 
            this.lblPosted.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPosted.Location = new System.Drawing.Point(269, 257);
            this.lblPosted.Name = "lblPosted";
            this.lblPosted.Size = new System.Drawing.Size(209, 27);
            this.lblPosted.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPosted);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.txtTwitter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTwitter;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPosted;
    }
}

