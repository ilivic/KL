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
    /// Логика взаимодействия для PageShowMyComm.xaml
    /// </summary>
    public partial class PageShowMyComm : Page
    {
        public PageShowMyComm()
        {
            InitializeComponent();
            ListComm.ItemsSource = App.Connection.Comments.Where(z => z.User_id == ClassCorr.CorrUser.id_user).ToList();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var sel = (sender as Button).DataContext as ADOApp.Comments;
            var com = App.Connection.States.First(z => z.id_state == sel.State_id);
            NavigationService.Navigate(new PageShowCorrState(com));
        }
    }
}
