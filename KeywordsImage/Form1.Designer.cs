namespace KeywordsImage
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.OperateButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 92);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 40);
            this.textBox1.TabIndex = 0;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(171, 254);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(223, 45);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Check Files Keywords";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // OperateButton
            // 
            this.OperateButton.Location = new System.Drawing.Point(171, 176);
            this.OperateButton.Name = "OperateButton";
            this.OperateButton.Size = new System.Drawing.Size(223, 52);
            this.OperateButton.TabIndex = 3;
            this.OperateButton.Text = "Begin Operation";
            this.OperateButton.UseSelectable = true;
            this.OperateButton.Click += new System.EventHandler(this.Operate);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 434);
            this.Controls.Add(this.OperateButton);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Image";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton OperateButton;
    }
}

