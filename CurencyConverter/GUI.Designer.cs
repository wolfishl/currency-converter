
using System;
using System.Collections.Generic;

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
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.cbStartCurrency = new System.Windows.Forms.ComboBox();
            this.cbEndCurrency = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStartCurr = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.lblError2 = new System.Windows.Forms.Label();            
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
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(622, 56);
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
            this.lblResult.Location = new System.Drawing.Point(60, 88);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(52, 17);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Result:";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(117, 87);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(112, 22);
            this.tbResult.TabIndex = 7;
            // 
            // cbStartCurrency
            // 
            this.cbStartCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStartCurrency.FormattingEnabled = true;
            this.cbStartCurrency.Items.AddRange(new object[] {
            "USD",
            "GBP",
            "ILS",
            "LBP",
            "EUR"});
            this.cbStartCurrency.Location = new System.Drawing.Point(415, 33);
            this.cbStartCurrency.Name = "cbStartCurrency";
            this.cbStartCurrency.Size = new System.Drawing.Size(138, 24);
            this.cbStartCurrency.TabIndex = 8;
            // 
            // cbEndCurrency
            // 
            this.cbEndCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEndCurrency.FormattingEnabled = true;
            this.cbEndCurrency.Items.AddRange(new object[] {
            "USD",
            "GBP",
            "ILS",
            "LBP",
            "EUR"});
            this.cbEndCurrency.Location = new System.Drawing.Point(415, 87);
            this.cbEndCurrency.Name = "cbEndCurrency";
            this.cbEndCurrency.Size = new System.Drawing.Size(138, 24);
            this.cbEndCurrency.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ending Currency: ";
            // 
            // lblStartCurr
            // 
            this.lblStartCurr.AutoSize = true;
            this.lblStartCurr.Location = new System.Drawing.Point(291, 36);
            this.lblStartCurr.Name = "lblStartCurr";
            this.lblStartCurr.Size = new System.Drawing.Size(122, 17);
            this.lblStartCurr.TabIndex = 10;
            this.lblStartCurr.Text = "Starting Currency:";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Crimson;
            this.lblError.Location = new System.Drawing.Point(129, 56);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(28, 17);
            this.lblError.TabIndex = 12;
            this.lblError.Text = "     ";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(117, 31);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(112, 22);
            this.tbAmount.TabIndex = 2;
            // 
            // lblError2
            // 
            this.lblError2.AutoSize = true;
            this.lblError2.ForeColor = System.Drawing.Color.Crimson;
            this.lblError2.Location = new System.Drawing.Point(421, 124);
            this.lblError2.Name = "lblError2";
            this.lblError2.Size = new System.Drawing.Size(28, 17);
            this.lblError2.TabIndex = 13;
            this.lblError2.Text = "     ";
            this.lblError2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 470);
            this.Controls.Add(this.lblError2);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.cbStartCurrency);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStartCurr);
            this.Controls.Add(this.cbEndCurrency);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.lblAmount);
            this.Name = "GUI";
            this.Text = "Form1";
           // ((System.ComponentModel.ISupportInitialize)(this.chartCurrency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }



        #endregion

        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.ComboBox cbStartCurrency;
        private System.Windows.Forms.ComboBox cbEndCurrency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStartCurr;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label lblError2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCurrency;
    }
}

