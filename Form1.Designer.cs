namespace Currency_Converter
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
            this.UpdateLabel = new System.Windows.Forms.Label();
            this.FromCurrency = new System.Windows.Forms.ComboBox();
            this.ToCurrency = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.NumericUpDown();
            this.ConvertValueLabel = new System.Windows.Forms.Label();
            this.ConvertValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateLabel
            // 
            this.UpdateLabel.AutoSize = true;
            this.UpdateLabel.Location = new System.Drawing.Point(12, 9);
            this.UpdateLabel.Name = "UpdateLabel";
            this.UpdateLabel.Size = new System.Drawing.Size(85, 13);
            this.UpdateLabel.TabIndex = 0;
            this.UpdateLabel.Text = "Rates Updated: ";
            // 
            // FromCurrency
            // 
            this.FromCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FromCurrency.FormattingEnabled = true;
            this.FromCurrency.Location = new System.Drawing.Point(31, 92);
            this.FromCurrency.Name = "FromCurrency";
            this.FromCurrency.Size = new System.Drawing.Size(88, 21);
            this.FromCurrency.TabIndex = 2;
            // 
            // ToCurrency
            // 
            this.ToCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ToCurrency.FormattingEnabled = true;
            this.ToCurrency.Location = new System.Drawing.Point(138, 92);
            this.ToCurrency.Name = "ToCurrency";
            this.ToCurrency.Size = new System.Drawing.Size(89, 21);
            this.ToCurrency.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Amount:";
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(93, 163);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(75, 23);
            this.ConvertButton.TabIndex = 8;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // amount
            // 
            this.amount.DecimalPlaces = 2;
            this.amount.Location = new System.Drawing.Point(138, 37);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(65, 20);
            this.amount.TabIndex = 9;
            this.amount.Leave += amountLeave;
            // 
            // ConvertValueLabel
            // 
            this.ConvertValueLabel.AutoSize = true;
            this.ConvertValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertValueLabel.Location = new System.Drawing.Point(45, 126);
            this.ConvertValueLabel.Name = "ConvertValueLabel";
            this.ConvertValueLabel.Size = new System.Drawing.Size(74, 13);
            this.ConvertValueLabel.TabIndex = 10;
            this.ConvertValueLabel.Text = "Conversion:";
            // 
            // ConvertValue
            // 
            this.ConvertValue.AutoSize = true;
            this.ConvertValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertValue.Location = new System.Drawing.Point(135, 126);
            this.ConvertValue.Name = "ConvertValue";
            this.ConvertValue.Size = new System.Drawing.Size(0, 13);
            this.ConvertValue.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 198);
            this.Controls.Add(this.ConvertValue);
            this.Controls.Add(this.ConvertValueLabel);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToCurrency);
            this.Controls.Add(this.FromCurrency);
            this.Controls.Add(this.UpdateLabel);
            this.Name = "Form1";
            this.Text = "Currency Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void amount_Leave(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label UpdateLabel;
        private System.Windows.Forms.ComboBox FromCurrency;
        private System.Windows.Forms.ComboBox ToCurrency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.NumericUpDown amount;
        private System.Windows.Forms.Label ConvertValueLabel;
        private System.Windows.Forms.Label ConvertValue;
    }
}

