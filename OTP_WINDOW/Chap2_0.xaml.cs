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

namespace OTP_WINDOW
{
    /// <summary>
    /// Chap2_0.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Chap2_0 : Page
    {
        public Chap2_0()
        {
            InitializeComponent();
        }

        private void PreviousButton_Click(object sender, RoutedEventArgs e)
        {
            Chap1_3 newPage = new Chap1_3();
            NavigationService.Navigate(newPage);
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            Chap2_0 newPage = new Chap2_0();
            NavigationService.Navigate(newPage);
        }
    }
}
