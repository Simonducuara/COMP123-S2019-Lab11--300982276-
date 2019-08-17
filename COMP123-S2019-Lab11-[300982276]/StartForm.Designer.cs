namespace COMP123_S2019_Assignment5__300982276_
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
            this.SavedOrderButton = new System.Windows.Forms.Button();
            this.StartNewOrderButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.StartLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SavedOrderButton
            // 
            this.SavedOrderButton.Location = new System.Drawing.Point(319, 265);
            this.SavedOrderButton.Name = "SavedOrderButton";
            this.SavedOrderButton.Size = new System.Drawing.Size(113, 41);
            this.SavedOrderButton.TabIndex = 0;
            this.SavedOrderButton.Text = "Open a Saved Order";
            this.SavedOrderButton.UseVisualStyleBackColor = true;
            this.SavedOrderButton.Click += new System.EventHandler(this.SavedOrderButton_Click);
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
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(319, 326);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(113, 37);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // StartLabel
            // 
            this.StartLabel.Location = new System.Drawing.Point(306, 83);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(144, 32);
            this.StartLabel.TabIndex = 3;
            this.StartLabel.Text = "Order Your Computer Today";
            this.StartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 471);
            this.ControlBox = false;
            this.Controls.Add(this.StartLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.StartNewOrderButton);
            this.Controls.Add(this.SavedOrderButton);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Dollar Computer";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SavedOrderButton;
        private System.Windows.Forms.Button StartNewOrderButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label StartLabel;
    }
}

