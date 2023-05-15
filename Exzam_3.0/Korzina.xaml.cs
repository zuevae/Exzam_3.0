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

namespace Exzam_3._0
{
    /// <summary>
    /// Логика взаимодействия для Korzina.xaml
    /// </summary>
    public partial class Korzina : Page
    {
        public Frame frame1;
        public Korzina(Frame frame)
        {
            InitializeComponent();
            frame1 = frame;
        }

        private void Back_Click(object sender, RoutedEventArgs e)   //кнопка перехода со сраницы "Korzina" на "Books"
        {
            frame1.Navigate(new Books(frame1));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
