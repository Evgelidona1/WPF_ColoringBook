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
    /// Interaction logic for Picture2.xaml
    /// </summary>
    public partial class Picture2 : Page
    {
        public Picture2()
        {
            InitializeComponent();
        }
        private void ReturnButtonClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MyGame());
            //Return.Content=new MainWindow();
        }
    }
}
