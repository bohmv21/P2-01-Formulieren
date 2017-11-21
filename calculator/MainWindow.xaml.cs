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

namespace calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double intNumber1;
        public double intNumber2;
        public int Uitkomst;
        public MainWindow()
        {
            InitializeComponent();
            Display.Text = Convert.ToString(Uitkomst);
            
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = Convert.ToString(intNumber1 + intNumber2);
        }

        private void Min_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = Convert.ToString(intNumber1 - intNumber2);
        }

        private void Mult_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = Convert.ToString(intNumber1 * intNumber2);
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = Convert.ToString(intNumber1 / intNumber2);
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Number1.Text = "0";
            Number2.Text = "0";
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Number1.Text == "")
                return;

            intNumber1 = Convert.ToDouble(Number1.Text);

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if (Number2.Text == "")
                return;

            intNumber2 = Convert.ToDouble(Number2.Text);
        }
    }
}
