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
    /// Логика взаимодействия для PageAddNewState.xaml
    /// </summary>
    public partial class PageAddNewState : Page
    {
        private static byte[] _img { get; set; }
        private static byte[] _file { get; set; }
        public PageAddNewState()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.ShowDialog();
                _img = File.ReadAllBytes(dialog.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                App.Connection.States.Add(new ADOApp.States()
                {
                    Body = TxtBody.Text,
                    Title = TxtTitle.Text,
                    image = _img,
                    Files = _file,
                    Creator = ClassCorr.CorrUser.id_user
                });
                App.Connection.SaveChanges();
                MessageBox.Show("Статья добавленна");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.ShowDialog();
                _file = File.ReadAllBytes(dialog.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
