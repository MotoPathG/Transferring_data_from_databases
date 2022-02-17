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
using TDD;

namespace TDD_Example
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TDD.TDD Client;
        public MainWindow()
        {
            InitializeComponent();
        }

        public void TDDInit()
        {
            Client = new TDD.TDD(
                new TDD.Models.Configuration(
                    new TDD.Models.DatabaseConfiguration("localhost", "2302", false, "root", "", "tdb_example", TDD.Models.DatabaseTypes.PostgreSQL),
                    new TDD.Models.DatabaseConfiguration("localhost", "2302", false, "root", "", "tdb_example", TDD.Models.DatabaseTypes.MYSQLServer)
                    )
                );
        }
    }
}