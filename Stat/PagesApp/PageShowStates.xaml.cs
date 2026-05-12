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

namespace Stat.PagesApp
{
    /// <summary>
    /// Логика взаимодействия для PageShowStates.xaml
    /// </summary>
    public partial class PageShowStates : Page
    {
        public PageShowStates()
        {
            InitializeComponent();
            ListStates.ItemsSource = App.Connection.States.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var sel = (sender as Button).DataContext as ADOApp.States;
            NavigationService.Navigate(new PageShowCorrState(sel));
        }
    }
}
