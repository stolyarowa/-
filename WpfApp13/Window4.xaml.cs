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

namespace WpfApp13
{
    /// <summary>
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void newWash(object sender, RoutedEventArgs e)
        {

        }

        private void NewPeoples(object sender, RoutedEventArgs e)
        {
            Window4 Admin = new Window4();
            Window5 NewPeoples = new Window5();
            NewPeoples.Show();
            Admin.Close();
        }

        private void SaveReport(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Успешно!", "Сохранение отчёта");
        }
    }
}

