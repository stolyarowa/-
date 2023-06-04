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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class MainWashes : Window
    {
        public MainWashes()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void activ_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MainWashes Washes = new MainWashes();
            Window3 Status = new Window3();
            Status.Show();
            Washes.Close();

        }

        private void finish_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MainWashes Washes = new MainWashes();
            Window3 Status = new Window3();
            Status.Show();
            Washes.Close();
        }

        private void newWash(object sender, RoutedEventArgs e)
        {
            MainWashes Washes = new MainWashes();
            Window2 NewWashes = new Window2();
            NewWashes.Show();
            Washes.Close();
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Успешно!", "Сохранение отчёта");
        }
    }
}
