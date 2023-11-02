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

namespace PAINTER
{
    /// <summary>
    /// Interaction logic for MyGame.xaml
    /// </summary>
    public partial class MyGame : Page
    {
        public MyGame()
        {
            InitializeComponent();
        }

        private void ReturnButtonClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StartPage());
            //Return.Content=new MainWindow();
        }
        private void Pic1ButtonClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Picture1());
            //Return.Content=new MainWindow();
        }
        private void Pic2ButtonClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Picture2());
            //Return.Content=new MainWindow();
        }
    }
}
