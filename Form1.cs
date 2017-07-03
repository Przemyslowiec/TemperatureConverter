using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class window : Form
    {
        public window()
        {
            InitializeComponent();
        }

        private void MessageBox_Error()
        {
            string message = "Somethig gone wrong, do you want try again";
            string caption = "Error Detected in Input";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.No)
            {
                // Closes the parent form.
                this.Close();
            }
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                celsjus_textBox.Text = "";
                kelvin_textBox.Text = "";
                ferenheit_textBox.Text = "";
            }
        }

        private void celsjus_eneter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter)
            {
                try
                {
                    double value = Convert.ToDouble(celsjus_textBox.Text);
                    if (value >= -273.15)
                    {
                        kelvin_textBox.Text = Convert.ToString(Math.Round(value + 273.15, 2));
                        ferenheit_textBox.Text = Convert.ToString(Math.Round(1.8 * value + 32, 2));
                    }
                    else
                    {
                        MessageBox_Error();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Unable to convert '{0}' to a Double.");
                    MessageBox_Error();
                }
                catch (OverflowException)
                {
                    Console.WriteLine("'{0}' is outside the range of a Double.");
                    MessageBox_Error();
                }
            }
        }

        private void kelvin_enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    double value = Convert.ToDouble(kelvin_textBox.Text);
                    if (value >= 0)
                    {
                        celsjus_textBox.Text = Convert.ToString(Math.Round(value - 273.15, 2));
                        ferenheit_textBox.Text = Convert.ToString(Math.Round((value - 273.15) * 1.8 + 32, 2));
                    }
                    else
                    {
                        MessageBox_Error();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Unable to convert '{0}' to a Double.");
                    MessageBox_Error();
                }
                catch (OverflowException)
                {
                    Console.WriteLine("'{0}' is outside the range of a Double.");
                    MessageBox_Error();
                }
            }
        }

        private void ferenheit_enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    double value = Convert.ToDouble(ferenheit_textBox.Text);
                    if (value >= -459.67)
                    {
                        celsjus_textBox.Text = Convert.ToString(Math.Round((0.555555555555) * (value - 32), 2));
                        kelvin_textBox.Text = Convert.ToString(Math.Round(((0.555555555555) * (value - 32)) + 273.15, 2));
                    }
                    else
                    {
                        MessageBox_Error();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Unable to convert '{0}' to a Double.");
                    MessageBox_Error();
                }
                catch (OverflowException)
                {
                    Console.WriteLine("'{0}' is outside the range of a Double.");
                    MessageBox_Error();
                }
            }
        }
    }
}
