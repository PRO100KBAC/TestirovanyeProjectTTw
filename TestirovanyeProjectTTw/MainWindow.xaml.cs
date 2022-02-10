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
using TestirovanyeProjectTTwLibrary;

namespace TestirovanyeProjectTTw
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ResultButtonClick(object sender, RoutedEventArgs e)
        {
            switch (SnilsClass.CheckMedicalCode(SnilsNumTextBox.Text)){
                case true:
                    ResultTextBlock.Text += "да";
                    break;
                case false:
                    ResultTextBlock.Text += "нет";
                    break;
            }
        }
    }
}
