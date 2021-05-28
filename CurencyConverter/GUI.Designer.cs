
using System;

namespace CurencyConverter
{
    /*
     * This class should have: 
     * -2 textfields 
     * -2 dropdown menus with the list of the 5 currencyoptions in each
     * -A go button
     * -A graph
     * 
     * On go, it should call to: 
     * -Converter and then display the amount returned
     * -Graph to generate the graph
     */
    partial class GUI
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
            this.lblAmount = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.cbCurrency = new System.Windows.Forms.ComboBox();
            this.cbCurrencyFinal = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(60, 33);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(64, 17);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount: ";
            this.lblAmount.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(117, 31);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(112, 22);
            this.tbAmount.TabIndex = 2;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(198, 115);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(92, 34);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(60, 62);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(52, 17);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Result:";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(117, 59);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(112, 22);
            this.tbResult.TabIndex = 7;
            // 
            // cbCurrency
            // 
            this.cbCurrency.FormattingEnabled = true;
            this.cbCurrency.Location = new System.Drawing.Point(263, 33);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(121, 24);
            this.cbCurrency.TabIndex = 8;
            this.cbCurrency.Text = "Currency";
            // 
            // cbCurrencyFinal
            // 
            this.cbCurrencyFinal.FormattingEnabled = true;
            this.cbCurrencyFinal.Location = new System.Drawing.Point(263, 59);
            this.cbCurrencyFinal.Name = "cbCurrencyFinal";
            this.cbCurrencyFinal.Size = new System.Drawing.Size(121, 24);
            this.cbCurrencyFinal.TabIndex = 9;
            this.cbCurrencyFinal.Text = "Currency";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 191);
            this.Controls.Add(this.cbCurrencyFinal);
            this.Controls.Add(this.cbCurrency);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.lblAmount);
            this.Name = "GUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        #endregion

        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.ComboBox cbCurrency;
        private System.Windows.Forms.ComboBox cbCurrencyFinal;
    }
}

