﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace PROG6221_Part3_St10071737
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



        public MainWindow()
        {
            InitializeComponent();
        }

        private void GitButton_Click(object sender, RoutedEventArgs e)
        {
            string websiteUrl = "https://github.com/ST10071737/PROG6221_Part3_St10071737";
            Process.Start(new ProcessStartInfo(websiteUrl));
        }

        private void ExitButton_Click(Object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
