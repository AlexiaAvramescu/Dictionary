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
    /// Interaction logic for AdminView.xaml
    /// </summary>
    public partial class AdminView : Page
    {
        public AdminView(object dContext)
        {
            InitializeComponent();
            DataContext = dContext;
        }

        private void SelectImgBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddWordBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!(DataContext as WordCollection).AddWord(value.Text, description.Text, category.Text, "imgPath"))
            { MessageBox.Show("Word, desctription, or category field empty."); }
        }

        private void BackArrowBtn_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).MainFrame.GoBack();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            (DataContext as WordCollection).SelectedWord = (sender as ListBox).SelectedItem as Word;
        }
    }
}
