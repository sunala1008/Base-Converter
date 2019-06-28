namespace Base_Converter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnToBase2 = new System.Windows.Forms.Button();
            this.btnToHex2 = new System.Windows.Forms.Button();
            this.btnToBase10_1 = new System.Windows.Forms.Button();
            this.btnToBase10_3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToBase2
            // 
            this.btnToBase2.Location = new System.Drawing.Point(43, 12);
            this.btnToBase2.Name = "btnToBase2";
            this.btnToBase2.Size = new System.Drawing.Size(130, 23);
            this.btnToBase2.TabIndex = 0;
            this.btnToBase2.Text = "10진수 → 2진수";
            this.btnToBase2.UseVisualStyleBackColor = true;
            this.btnToBase2.Click += new System.EventHandler(this.BtnToBase2_Click);
            // 
            // btnToHex2
            // 
            this.btnToHex2.Location = new System.Drawing.Point(43, 83);
            this.btnToHex2.Name = "btnToHex2";
            this.btnToHex2.Size = new System.Drawing.Size(130, 23);
            this.btnToHex2.TabIndex = 2;
            this.btnToHex2.Text = "10진수 → 16진수";
            this.btnToHex2.UseVisualStyleBackColor = true;
            this.btnToHex2.Click += new System.EventHandler(this.BtnToHex2_Click);
            // 
            // btnToBase10_1
            // 
            this.btnToBase10_1.Location = new System.Drawing.Point(43, 41);
            this.btnToBase10_1.Name = "btnToBase10_1";
            this.btnToBase10_1.Size = new System.Drawing.Size(130, 23);
            this.btnToBase10_1.TabIndex = 3;
            this.btnToBase10_1.Text = "2진수 → 10진수";
            this.btnToBase10_1.UseVisualStyleBackColor = true;
            this.btnToBase10_1.Click += new System.EventHandler(this.BtnToBase10_1_Click);
            // 
            // btnToBase10_3
            // 
            this.btnToBase10_3.Location = new System.Drawing.Point(43, 112);
            this.btnToBase10_3.Name = "btnToBase10_3";
            this.btnToBase10_3.Size = new System.Drawing.Size(130, 23);
            this.btnToBase10_3.TabIndex = 5;
            this.btnToBase10_3.Text = " 16진수 → 10진수";
            this.btnToBase10_3.UseVisualStyleBackColor = true;
            this.btnToBase10_3.Click += new System.EventHandler(this.BtnToBase10_3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(219, 148);
            this.Controls.Add(this.btnToBase10_3);
            this.Controls.Add(this.btnToBase10_1);
            this.Controls.Add(this.btnToHex2);
            this.Controls.Add(this.btnToBase2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToBase2;
        private System.Windows.Forms.Button btnToHex2;
        private System.Windows.Forms.Button btnToBase10_1;
        private System.Windows.Forms.Button btnToBase10_3;
    }
}