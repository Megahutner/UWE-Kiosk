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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UWEKiosk
{
    /// <summary>
    /// Interaction logic for SplashPage.xaml
    /// </summary>
    public partial class SplashPage : Page
    {
        public SplashPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("MapPage2.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);
        }

    }


}
