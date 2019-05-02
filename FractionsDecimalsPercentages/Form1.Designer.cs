namespace FractionsDecimalsPercentages
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
            this.textBoxDecimal = new System.Windows.Forms.TextBox();
            this.labelDecimal = new System.Windows.Forms.Label();
            this.labelPercentage = new System.Windows.Forms.Label();
            this.textBoxPercentage = new System.Windows.Forms.TextBox();
            this.textBoxNumerator = new System.Windows.Forms.TextBox();
            this.textBoxDenominator = new System.Windows.Forms.TextBox();
            this.labelFraction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxDecimal
            // 
            this.textBoxDecimal.Location = new System.Drawing.Point(12, 37);
            this.textBoxDecimal.Name = "textBoxDecimal";
            this.textBoxDecimal.Size = new System.Drawing.Size(100, 20);
            this.textBoxDecimal.TabIndex = 0;
            this.textBoxDecimal.Text = "1";
            this.textBoxDecimal.TextChanged += new System.EventHandler(this.TextBoxDecimal_TextChanged);
            // 
            // labelDecimal
            // 
            this.labelDecimal.AutoSize = true;
            this.labelDecimal.Location = new System.Drawing.Point(9, 9);
            this.labelDecimal.Name = "labelDecimal";
            this.labelDecimal.Size = new System.Drawing.Size(45, 13);
            this.labelDecimal.TabIndex = 1;
            this.labelDecimal.Text = "Decimal";
            // 
            // labelPercentage
            // 
            this.labelPercentage.AutoSize = true;
            this.labelPercentage.Location = new System.Drawing.Point(115, 9);
            this.labelPercentage.Name = "labelPercentage";
            this.labelPercentage.Size = new System.Drawing.Size(62, 13);
            this.labelPercentage.TabIndex = 2;
            this.labelPercentage.Text = "Percentage";
            // 
            // textBoxPercentage
            // 
            this.textBoxPercentage.Location = new System.Drawing.Point(118, 37);
            this.textBoxPercentage.Name = "textBoxPercentage";
            this.textBoxPercentage.Size = new System.Drawing.Size(100, 20);
            this.textBoxPercentage.TabIndex = 3;
            this.textBoxPercentage.Text = "100";
            this.textBoxPercentage.TextChanged += new System.EventHandler(this.TextBoxPercentage_TextChanged);
            // 
            // textBoxNumerator
            // 
            this.textBoxNumerator.Location = new System.Drawing.Point(225, 25);
            this.textBoxNumerator.Name = "textBoxNumerator";
            this.textBoxNumerator.Size = new System.Drawing.Size(51, 20);
            this.textBoxNumerator.TabIndex = 4;
            this.textBoxNumerator.Text = "1";
            this.textBoxNumerator.TextChanged += new System.EventHandler(this.TextBoxNumerator_TextChanged);
            // 
            // textBoxDenominator
            // 
            this.textBoxDenominator.Location = new System.Drawing.Point(225, 51);
            this.textBoxDenominator.Name = "textBoxDenominator";
            this.textBoxDenominator.Size = new System.Drawing.Size(51, 20);
            this.textBoxDenominator.TabIndex = 5;
            this.textBoxDenominator.Text = "1";
            this.textBoxDenominator.TextChanged += new System.EventHandler(this.TextBoxDenominator_TextChanged);
            // 
            // labelFraction
            // 
            this.labelFraction.AutoSize = true;
            this.labelFraction.Location = new System.Drawing.Point(222, 9);
            this.labelFraction.Name = "labelFraction";
            this.labelFraction.Size = new System.Drawing.Size(45, 13);
            this.labelFraction.TabIndex = 6;
            this.labelFraction.Text = "Fraction";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 84);
            this.Controls.Add(this.labelFraction);
            this.Controls.Add(this.textBoxDenominator);
            this.Controls.Add(this.textBoxNumerator);
            this.Controls.Add(this.textBoxPercentage);
            this.Controls.Add(this.labelPercentage);
            this.Controls.Add(this.labelDecimal);
            this.Controls.Add(this.textBoxDecimal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "FDP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDecimal;
        private System.Windows.Forms.Label labelDecimal;
        private System.Windows.Forms.Label labelPercentage;
        private System.Windows.Forms.TextBox textBoxPercentage;
        private System.Windows.Forms.TextBox textBoxNumerator;
        private System.Windows.Forms.TextBox textBoxDenominator;
        private System.Windows.Forms.Label labelFraction;
    }
}

