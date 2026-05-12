using Stat.ClassApp;
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
    /// Логика взаимодействия для PageMenu.xaml
    /// </summary>
    public partial class PageMenu : Page
    {
        public PageMenu()
        {
            InitializeComponent();
            this.DataContext = ClassCorr.CorrUser;
            if (ClassCorr.CorrUser.Role_id != 1)
            {
                btnCreate.IsEnabled = false;
            }
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SapFrame.NavigationService.Navigate(new PageChUser());
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            SapFrame.NavigationService.Navigate(new PageAddNewState());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SapFrame.NavigationService.Navigate(new PageShowStates());

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SapFrame.NavigationService.Navigate(new PageShowMyComm());

        }
    }
}