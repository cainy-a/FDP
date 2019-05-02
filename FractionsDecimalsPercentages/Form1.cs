using System;
using System.Windows.Forms;
using static VCSKICKS.DecimalToFraction;

namespace FractionsDecimalsPercentages
{
    public partial class Form1 : Form
    {
        // The Decimal to Fraction code & struct is from C# Kicks, the rest of the code is by me.
        decimal dec = 1;
        int percent = 100;
        int num = 1;
        int denom = 1;
        bool writingtext = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBoxDecimal_TextChanged(object sender, EventArgs e)
        {
            if (writingtext == true)
            {
                return;
            }
            dec = Convert.ToDecimal(textBoxDecimal.Text);
            if (dec == 0)
            {
                return;
            }
            percent = Convert.ToInt32(dec * 100);
            num = ToFraction(Convert.ToDouble(dec)).Numerator;
            denom = ToFraction(Convert.ToDouble(dec)).Denominator;
            writingtext = true;
            textBoxPercentage.Text = percent.ToString();
            textBoxNumerator.Text = num.ToString();
            textBoxDenominator.Text = denom.ToString();
            writingtext = false;
        }

        private void TextBoxPercentage_TextChanged(object sender, EventArgs e)
        {
            if (writingtext == true)
            {
                return;
            }
            percent = Convert.ToInt32(textBoxPercentage.Text);
            if (percent == 0)
            {
                return;
            }
            dec = Convert.ToDecimal(percent / 100);
            num = ToFraction(Convert.ToDouble(dec)).Numerator;
            denom = ToFraction(Convert.ToDouble(dec)).Denominator;
            writingtext = true;
            textBoxDecimal.Text = dec.ToString();
            textBoxNumerator.Text = num.ToString();
            textBoxDenominator.Text = denom.ToString();
            writingtext = false;
        }

        private void TextBoxNumerator_TextChanged(object sender, EventArgs e)
        {
            if (writingtext == true)
            {
                return;
            }
            num = Convert.ToInt32(textBoxNumerator.Text);
            if (num == 0)
            {
                return;
            }
            dec = num / denom;
            percent = Convert.ToInt32(dec * 100);
            writingtext = true;
            textBoxDecimal.Text = dec.ToString();
            textBoxPercentage.Text = percent.ToString();
            writingtext = false;
        }

        private void TextBoxDenominator_TextChanged(object sender, EventArgs e)
        {
            if (writingtext == true)
            {
                return;
            }
            denom = Convert.ToInt32(textBoxDenominator.Text);
            if (denom == 0)
            {
                return;
            }
            dec = num / denom;
            percent = Convert.ToInt32(dec * 100);
            writingtext = true;
            textBoxDecimal.Text = dec.ToString();
            textBoxPercentage.Text = percent.ToString();
            writingtext = false;
        }
    }
}