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
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для Menu_st_smen.xaml
    /// </summary>
    public partial class Menu_st_smen : Window
    {
        public Menu_st_smen()
        {
            InitializeComponent();
        }

        private void На_главную_Click(object sender, RoutedEventArgs e)
        {
            MainWindow form = new MainWindow();
            form.Show();
            this.Close();
        }

        private void Внести_новое_событие_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Редактировать_событие_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Редактировать_профиль_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
