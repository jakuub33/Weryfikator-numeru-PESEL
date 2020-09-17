using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PESEL_App
{
    /// <summary>
    /// Program prawdza poprawność numeru PESEL, daty urodzenia oraz płeć.
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Guzik, który sprawdza czy numer PESEL jest poprawny.
        /// </summary>
        private void BtnCheckPesel_Click(object sender, RoutedEventArgs e)
        {
            if (txtPesel.Text.Length == 11)
            {
                int[] arrayPesel = ArrayPesel();

                int result = 0;
                int[] multipliers = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };

                for (int i = 0; i < multipliers.Length; i++)
                {
                    result += multipliers[i] * int.Parse(arrayPesel[i].ToString());
                }

                int rest = result % 10;
                if (rest == 0)
                {
                    if (arrayPesel[10] == 0)
                    {
                        MessageBox.Show("Pesel jest poprawny!", "Uwaga!", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("Pesel nie jest poprawny!", "Błąd!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    if (arrayPesel[10] == 10 - rest)
                    {
                        MessageBox.Show("Pesel jest poprawny!", "Uwaga!", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("Pesel nie jest poprawny!", "Błąd!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Pesel nie jest poprawny!", "Błąd!", MessageBoxButton.OK, MessageBoxImage.Error);                
            }
        }

        /// <summary>
        /// Guzik, który sprawdza czy data jest poprawna.
        /// </summary>
        private void BtnCheckDate_Click(object sender, RoutedEventArgs e)
        {
            if (txtPesel.Text.Length == 11)
            {
                string date = dpDateBirth.SelectedDate.Value.ToShortDateString();
                //Data z DatePicker
                int dayDP = Int32.Parse(date.Substring(0, 2));
                int monthDP = Int32.Parse(date.Substring(3, 2));
                int yearDP = Int32.Parse(date.Substring(6, 4));

                int[] arrayDate = new int[3];
                //Data z numeru PESEL
                int dayPesel = Int32.Parse(txtPesel.Text.Substring(4, 2));
                int monthPesel = Int32.Parse(txtPesel.Text.Substring(2, 2));
                int yearPesel = Int32.Parse(txtPesel.Text.Substring(0, 2));

                //Sprawdzenie stulecia
                if (yearDP >= 1800 && yearDP <= 1899)
                {
                    monthDP += 80;
                }
                else if (yearDP >= 2000 && yearDP <= 2099)
                {
                    monthDP += 20;
                }
                else if (yearDP >= 2100 && yearDP <= 2199)
                {
                    monthDP += 40;
                }
                else if (yearDP >= 2200 && yearDP <= 2299)
                {
                    monthDP += 60;
                }

                //Skrócenie roku np z 1999 na 99.
                string shortYearDP = yearDP.ToString().Substring(2, 2);

                if (dayDP == dayPesel && monthDP == monthPesel && int.Parse(shortYearDP) == yearPesel)
                {
                    MessageBox.Show("Data urodzenia jest prawidłowa!", "Uwaga!", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Data urodzenia jest nieprawidłowa!", "Błąd!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Pesel nie jest poprawny!", "Błąd!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Guzik za pomocą, którego sprawdzamy poprawność płci.
        /// </summary>
        private void btnCheckGender_Click(object sender, RoutedEventArgs e)
        {
            if (txtPesel.Text.Length == 11)
            {
                int[] arrayPesel = ArrayPesel();
                int genderIndex = arrayPesel[9];

                if (genderIndex % 2 == 0)
                {
                    if (rbK.IsChecked == true)
                    {
                        MessageBox.Show("Płeć jest prawidłowa.", "Uwaga!", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("Płeć jest nieprawidłowa", "Błąd!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    if (rbM.IsChecked == true)
                    {
                        MessageBox.Show("Płeć jest prawidłowa.", "Uwaga!", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("Płeć jest nieprawidłowa!", "Błąd!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Pesel nie jest poprawny!", "Błąd!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        
        /// <summary>
        /// Dodaje poszczególne numery PESEL do tablicy.
        /// </summary>
        private int[] ArrayPesel()
        {
            int[] arrayPesel = new int[11];

            for (int i = 0; i < arrayPesel.Length; i++)
            {
                arrayPesel[i] = Int32.Parse(txtPesel.Text.Substring(i, 1));
            }

            return arrayPesel;
        }

        /// <summary>
        /// Ta metoda pozwala wpisać tylko cyfry.
        /// </summary>
        private void OnlyDigits_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPesel.Text, "[^0-9]"))
            {
                MessageBox.Show("Możesz wpisać tylko cyfry!", "Błąd!", MessageBoxButton.OK, MessageBoxImage.Error);
                txtPesel.Text = "";
            }
        }

        /// <summary>
        /// Ta metoda sprawdza czy Pesel ma 11 cyfr.
        /// </summary>
        private void MinLength_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (txtPesel.Text.Length < 11)
            {
                tbMinLength.Text = "Pesel musi się składać z 11 cyfr!";
            }
            else
            {
                tbMinLength.Text = "";
            }
        }

        /// <summary>
        /// Guzik, który czyści TextBox.
        /// </summary>
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            txtPesel.Text = "";
        }
    }
}
