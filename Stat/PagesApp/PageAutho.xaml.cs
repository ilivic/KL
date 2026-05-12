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
    /// Логика взаимодействия для PageAutho.xaml
    /// </summary>
    public partial class PageAutho : Page
    {
        public PageAutho()
        {
            InitializeComponent();
        }

        private void ClEventAutho(object sender, RoutedEventArgs e)
        {
            var chec = App.Connection.Users.Where(z=>z.Login == TxtLogin.Text && z.password == TxtPass.Password).FirstOrDefault();
            if (chec != null)
            {
                ClassCorr.CorrUser = chec;
                NavigationService.Navigate(new PageMenu());
            }
            else
            {
                MessageBox.Show("пользовыатель не найден");
            }
        }
    }
}
