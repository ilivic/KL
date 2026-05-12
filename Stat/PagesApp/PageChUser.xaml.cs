using Microsoft.Win32;
using Stat.ClassApp;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для PageChUser.xaml
    /// </summary>
    public partial class PageChUser : Page
    {
        public PageChUser()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.ShowDialog();
                ClassCorr.CorrUser.Photo = File.ReadAllBytes(dialog.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            
        }

        private void ClEventSave(object sender, RoutedEventArgs e)
        {
            ClassCorr.CorrUser.Name = TxtName.Text;
            App.Connection.SaveChanges();
            MessageBox.Show("Перезагрузись)");
        }
    }
}
