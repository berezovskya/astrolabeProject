using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
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
    /// Interaction logic for VisitorQuery.xaml
    /// </summary>
    public partial class VisitorQuery : Window
    {
        public VisitorQuery()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Конструктор, с которым мы будем заполнять textbox'ы
        /// </summary>
        /// <param name="query"></param>
        public VisitorQuery(string query){
            DataTable dt = Utils.Select(query);
        }

        private void NewQuery_Click(object sender, RoutedEventArgs e)
        {
            //Posetitel1 p1 = new Posetitel1();
            //p1.show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
}
