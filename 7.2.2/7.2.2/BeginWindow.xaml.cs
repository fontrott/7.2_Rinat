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
using System.Windows.Shapes;

namespace _7._2._2
{
    /// <summary>
    /// Логика взаимодействия для BeginWindow.xaml
    /// </summary>
    public partial class BeginWindow : Window
    {
        public string str;
        public int level;
        public BeginWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                str = textBox.Text;
                Close();
            }
            catch
            {
                MessageBox.Show("Select an option and enter the text", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            if (pressed.Content.ToString() == "Color")
                level = 1;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            if (pressed.Content.ToString() == "Underline")
                level = 2;
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            if (pressed.Content.ToString() == "Border")
                level = 3;
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            if (pressed.Content.ToString() == "Italics")
                level = 4;
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
