namespace ConvertTextToMp3
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
            this.Convert = new System.Windows.Forms.Button();
            this.MakeNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(370, 160);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(161, 47);
            this.Convert.TabIndex = 0;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.button1_Click);
            // 
            // MakeNumber
            // 
            this.MakeNumber.Location = new System.Drawing.Point(119, 177);
            this.MakeNumber.Name = "MakeNumber";
            this.MakeNumber.Size = new System.Drawing.Size(137, 40);
            this.MakeNumber.TabIndex = 1;
            this.MakeNumber.Text = "MakeNumber";
            this.MakeNumber.UseVisualStyleBackColor = true;
            this.MakeNumber.Click += new System.EventHandler(this.MakeNumber_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MakeNumber);
            this.Controls.Add(this.Convert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button Convert;
        private System.Windows.Forms.Button MakeNumber;
    }
}

