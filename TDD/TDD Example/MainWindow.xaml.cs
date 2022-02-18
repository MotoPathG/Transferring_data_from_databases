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
                     
                    /* CONNECTION FOR FROM DATABASE*/
                     /* "Data Source", "Port (for server)", "Encrypt", "Username", "Password", "Database", "Basedata Type" */
                     new TDD.Models.DatabaseConfiguration("(LocalDB)\\MSSQLLocalDB", "2302", false, "", "", "Example", TDD.Models.DatabaseTypes.MYSQLServer),

                     /* CONNECTION FOR TO DATABASE*/
                     /* "Host", "Port", "Encrypt", "Username", "Password", "Database", "Basedata Type" */
                     new TDD.Models.DatabaseConfiguration("pgsql-174773.srv.hoster.ru", "2302", true, "srv174773_Test", "53FVsw1", "srv174773_Example", TDD.Models.DatabaseTypes.PostgreSQL)
                   )
                );
        }
    }
}
