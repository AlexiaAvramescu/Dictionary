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

namespace Dictionary.Pages
{
    /// <summary>
    /// Interaction logic for Entertainment.xaml
    /// </summary>
    public partial class Entertainment : Page
    {
        public Entertainment(object dContext)
        {
            InitializeComponent();
            DataContext = dContext;
        }

        private void goBackBtn_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).MainFrame.GoBack();
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
