using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace TimeCalculatorApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var beginTijdString = Tekstbox1.Text;
            var eindTijdString = Tekstbox2.Text;

            var dateTimeBeginTijd = DateTime.Parse(beginTijdString);
            var dateTimeEindTijd = DateTime.Parse(eindTijdString);

            var resultaat = new Berekeningen(dateTimeBeginTijd, dateTimeEindTijd);

            Tekstblock1.Text = $"Resultaat Uren:[{resultaat.hours}], Minuten:[{resultaat.minutes}]";
        }

        private void NummericCheckEvent(object sender, KeyEventArgs e)
        {
            Regex regex = new Regex("[0-9]");
            e.Handled = !regex.IsMatch(e.Key.ToString());
        }
    }
}
