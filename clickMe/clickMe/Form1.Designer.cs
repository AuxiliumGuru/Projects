
namespace clickMe
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
            this.clickBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.lblClick = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clickBtn
            // 
            this.clickBtn.Location = new System.Drawing.Point(76, 36);
            this.clickBtn.Name = "clickBtn";
            this.clickBtn.Size = new System.Drawing.Size(75, 23);
            this.clickBtn.TabIndex = 0;
            this.clickBtn.Text = "Click Me";
            this.clickBtn.UseVisualStyleBackColor = true;
            this.clickBtn.Click += new System.EventHandler(this.clickBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(76, 180);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // lblClick
            // 
            this.lblClick.AutoSize = true;
            this.lblClick.Location = new System.Drawing.Point(73, 110);
            this.lblClick.Name = "lblClick";
            this.lblClick.Size = new System.Drawing.Size(0, 13);
            this.lblClick.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 262);
            this.Controls.Add(this.lblClick);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clickBtn);
            this.Name = "Form1";
            this.Text = "Click Me";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clickBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label lblClick;
    }
}

