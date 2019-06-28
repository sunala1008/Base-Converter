namespace Base_Converter
{
    partial class BaseForm
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
            this.lblTextLeft = new System.Windows.Forms.Label();
            this.lblTextRight = new System.Windows.Forms.Label();
            this.txbValue = new System.Windows.Forms.TextBox();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTextLeft
            // 
            this.lblTextLeft.AutoSize = true;
            this.lblTextLeft.Location = new System.Drawing.Point(70, 23);
            this.lblTextLeft.Name = "lblTextLeft";
            this.lblTextLeft.Size = new System.Drawing.Size(41, 12);
            this.lblTextLeft.TabIndex = 0;
            this.lblTextLeft.Text = "10진수";
            // 
            // lblTextRight
            // 
            this.lblTextRight.AutoSize = true;
            this.lblTextRight.Location = new System.Drawing.Point(242, 23);
            this.lblTextRight.Name = "lblTextRight";
            this.lblTextRight.Size = new System.Drawing.Size(35, 12);
            this.lblTextRight.TabIndex = 1;
            this.lblTextRight.Text = "2진수";
            // 
            // txbValue
            // 
            this.txbValue.Location = new System.Drawing.Point(32, 38);
            this.txbValue.Name = "txbValue";
            this.txbValue.Size = new System.Drawing.Size(120, 21);
            this.txbValue.TabIndex = 2;
            this.txbValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbValue.Enter += new System.EventHandler(this.TxbValue_Enter);
            this.txbValue.Leave += new System.EventHandler(this.TxbValue_Leave);
            // 
            // txbResult
            // 
            this.txbResult.Location = new System.Drawing.Point(196, 38);
            this.txbResult.Name = "txbResult";
            this.txbResult.ReadOnly = true;
            this.txbResult.Size = new System.Drawing.Size(120, 21);
            this.txbResult.TabIndex = 3;
            this.txbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(158, 36);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(32, 23);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "→";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(345, 91);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txbResult);
            this.Controls.Add(this.txbValue);
            this.Controls.Add(this.lblTextRight);
            this.Controls.Add(this.lblTextLeft);
            this.Name = "BaseForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextLeft;
        private System.Windows.Forms.Label lblTextRight;
        private System.Windows.Forms.TextBox txbValue;
        private System.Windows.Forms.TextBox txbResult;
        private System.Windows.Forms.Button btnConvert;
    }
}

