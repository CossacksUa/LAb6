using System;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string input = txtInput.Text;

                if (input.ToLower() == "exit")
                {
                    Close();
                    return;
                }

                int year = int.Parse(input);

                if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
                {
                    labResult.Text = ($"Рік {year} є високосним.");
                }
                else
                {
                    labResult.Text = ($"Рік {year} НЕ Є високосним.");
                }
            }
            catch (FormatException)
            {
                labResult.Text = ("Помилка: Невірний формат введених даних.");
            }
            catch (OverflowException)
            {
                labResult.Text = ("Помилка: Введене число занадто велике або занадто мале.");
            }
            catch (Exception ex)
            {
                labResult.Text = ($"Помилка: {ex.Message}");
            }
        }

        private void butClean_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            labResult.Text = "";
        }
    }
}
