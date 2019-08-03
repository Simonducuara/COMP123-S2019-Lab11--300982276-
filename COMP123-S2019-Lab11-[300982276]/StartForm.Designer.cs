namespace COMP123_S2019_Lab11__300982276_
{
    partial class StartForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.StartNewOrderButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open a Saved Order";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // StartNewOrderButton
            // 
            this.StartNewOrderButton.Location = new System.Drawing.Point(319, 203);
            this.StartNewOrderButton.Name = "StartNewOrderButton";
            this.StartNewOrderButton.Size = new System.Drawing.Size(113, 37);
            this.StartNewOrderButton.TabIndex = 1;
            this.StartNewOrderButton.Text = "Start a New Order";
            this.StartNewOrderButton.UseVisualStyleBackColor = true;
            this.StartNewOrderButton.Click += new System.EventHandler(this.StartNewOrderButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(319, 326);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 37);
            this.button3.TabIndex = 2;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(306, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order Your Computer Today";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.StartNewOrderButton);
            this.Controls.Add(this.button1);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Dollar Computer";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button StartNewOrderButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}

