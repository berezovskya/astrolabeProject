﻿using System;
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
    /// Логика взаимодействия для About_us.xaml
    /// </summary>
    public partial class About_us : Window
    {
        public About_us()
        {
            InitializeComponent();
        }

        private void На_главную_Click(object sender, RoutedEventArgs e)
        {
            MainWindow form = new MainWindow();
            form.Show();
            this.Close();
        }
    }
}
