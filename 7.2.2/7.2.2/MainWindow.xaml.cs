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

namespace _7._2._2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string str;
        int level;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Begin_Click(object sender, RoutedEventArgs e)
        {
            // Открываем диалоговое окно для ввода слова и выбора режима
            BeginWindow dialog = new BeginWindow();
            dialog.ShowDialog();
            str = dialog.str;
            level = dialog.level;
        }

        private void Work_Click(object sender, RoutedEventArgs e)
        {
            // Открываем диалоговое окно с результатом перевода
            WorkWindow dialog = new WorkWindow(str, level);
            dialog.ShowDialog();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            AboutWindow form2 = new AboutWindow();
            form2.ShowDialog();
        }
    }
}
