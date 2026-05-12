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
    /// Логика взаимодействия для PageShowCorrState.xaml
    /// </summary>
    public partial class PageShowCorrState : Page
    {
        private static ADOApp.States _sel {  get; set; }
        public PageShowCorrState(ADOApp.States sel)
        {
            InitializeComponent();
            _sel = sel;
            this.DataContext = _sel;
            ListComm.ItemsSource = App.Connection.Comments.Where(z => z.State_id == _sel.id_state).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TxtComment.Text != "")
            {
                App.Connection.Comments.Add(new ADOApp.Comments()
                {
                    Body = TxtComment.Text,
                    Title = ClassCorr.CorrUser.Name,
                    Users = ClassCorr.CorrUser,
                    States = _sel
                });
                App.Connection.SaveChanges();
                NavigationService.Navigate(new PageShowCorrState(_sel));
            }
        }
    }
}
