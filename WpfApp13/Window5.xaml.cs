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
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
        }

        private void LoginBox1(object sender, MouseButtonEventArgs e)
        {
            InitializeComponent();
            Surname.Clear();
        }
        private void LoginBox2(object sender, MouseButtonEventArgs e)
        {
            InitializeComponent();
            Name.Clear();
        }
        private void LoginBox3(object sender, MouseButtonEventArgs e)
        {
            InitializeComponent();
            Patronymic.Clear();
        }
        private void LoginBox4(object sender, MouseButtonEventArgs e)
        {
            InitializeComponent();
            Login.Clear();
        }
        private void LoginBox5(object sender, MouseButtonEventArgs e)
        {
            InitializeComponent();
            Password.Clear();
        }

        private void Btnnewpeople(object sender, RoutedEventArgs e)
        {
            Window5 NewPeoples = new Window5();
            Window4 Admin = new Window4();
            Admin.Show();
            NewPeoples.Close();
        }
    }
}
