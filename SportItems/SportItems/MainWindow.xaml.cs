﻿using SportItems.Classes;
using SportItems.Pages;
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

namespace SportItems
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            NavClass.frame = MainFrame; //передаем окно в статический класс
            NavClass.PagesDictionary.TryGetValue("MainWindowPage", out Page? FoundPage);
            NavClass.frame.Navigate(FoundPage); //устанавливаем в окно страницу
        }
    }
}
