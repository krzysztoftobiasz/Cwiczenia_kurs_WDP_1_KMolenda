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

namespace HelloWPFApp
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBoxImie_LostFocus(object sender, RoutedEventArgs e)
        {
            LabelKomunikat1.Content = "Witaj, " + textBoxImie.Text + " " + textBoxNazwisko.Text;
        }

        private void TextBoxNazwisko_LostFocus(object sender, RoutedEventArgs e)
        {
            LabelKomunikat1.Content = "Witaj, " + textBoxImie.Text + " " + textBoxNazwisko.Text;
        }

        private void TextBoxWiek_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBoxWiek_LostFocus(object sender, RoutedEventArgs e)
        {
            int wiek = Convert.ToInt32(textBoxWiek.Text);
            if (wiek < 67)
            {
                LabelKomunikat2.Content = string.Format(" do emerytury zostało Ci {0} lat", 67 - wiek);
            }
            else
            {
                LabelKomunikat2.Content = " jesteś emerytem";
            }
        }

        private void ButtonWyczysc_Click(object sender, RoutedEventArgs e)
        {
            LabelKomunikat1.Content = "";
            LabelKomunikat2.Content = "";
            textBoxImie.Text = "";
            textBoxNazwisko.Text = "";
            textBoxWiek.Text = "";
        }
    }
}
