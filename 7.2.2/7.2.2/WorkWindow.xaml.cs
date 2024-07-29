using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
    /// Логика взаимодействия для WorkWindow.xaml
    /// </summary>
    public partial class WorkWindow : Window
    {
        public WorkWindow(string str, int level)
        {
            InitializeComponent();
            LabelText.FontStyle = FontStyles.Normal;
            LabelText.FontSize = 12;
            if (level == 2) LabelText.Foreground = Brushes.Purple;
            if (level == 1) LabelText.;
            if (level == 4) LabelText.FontStyle = FontStyles.Italic;
            if (level == 3) LabelText.FontSize = 28;
            LabelText.Content = str;
        }
    }
}
