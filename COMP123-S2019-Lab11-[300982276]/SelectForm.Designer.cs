namespace COMP123_S2019_Lab11__300982276_
{
    partial class SelectForm
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
            this.SelectFormCancelButton = new System.Windows.Forms.Button();
            this.SelectFormNextButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dollar Computer Hardware List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your Selection";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectFormCancelButton
            // 
            this.SelectFormCancelButton.Location = new System.Drawing.Point(503, 399);
            this.SelectFormCancelButton.Name = "SelectFormCancelButton";
            this.SelectFormCancelButton.Size = new System.Drawing.Size(75, 23);
            this.SelectFormCancelButton.TabIndex = 2;
            this.SelectFormCancelButton.Text = "Cancel";
            this.SelectFormCancelButton.UseVisualStyleBackColor = true;
            // 
            // SelectFormNextButton
            // 
            this.SelectFormNextButton.Location = new System.Drawing.Point(612, 399);
            this.SelectFormNextButton.Name = "SelectFormNextButton";
            this.SelectFormNextButton.Size = new System.Drawing.Size(75, 23);
            this.SelectFormNextButton.TabIndex = 3;
            this.SelectFormNextButton.Text = "Next";
            this.SelectFormNextButton.UseVisualStyleBackColor = true;
            this.SelectFormNextButton.Click += new System.EventHandler(this.SelectFormNextButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 401);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 20);
            this.textBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(628, 310);
            this.dataGridView1.TabIndex = 5;
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SelectFormNextButton);
            this.Controls.Add(this.SelectFormCancelButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Your Computer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SelectFormCancelButton;
        private System.Windows.Forms.Button SelectFormNextButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}