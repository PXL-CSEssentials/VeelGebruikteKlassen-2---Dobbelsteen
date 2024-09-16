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

namespace VeelGebruikteKlassen_2___Dobbelsteen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random _random = new Random();
        private StringBuilder _stringBuilder = new StringBuilder();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            /*
            TxtResultaat.Clear();
            const int teGooien = 6;
            int gegooid = 0;
            int i = 0;
            while (gegooid != teGooien)
            {
                gegooid = rnd.Next(1, 7); // getal van 1 tot en met 6
                i++;
                TxtResultaat.Text += $"Worp {i,2} geeft {gegooid}\r\n";
            }
            */
            _stringBuilder.Clear();
            const int ToThrow = 6;
            int thrown = 0;
            int i = 0;
            do
            {
                thrown = _random.Next(1, 7); // getal van 1 tot en met 6
                i++;
                _stringBuilder.AppendLine($"Worp {i,2} geeft {thrown}");

            } while (thrown != ToThrow);
            resultTextBox.Text = _stringBuilder.ToString();
        }

        private void newButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Clear();
            startButton.Focus();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
