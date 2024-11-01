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

namespace WpfApp21
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Dictionary<int, string> slovar;

        public MainWindow()
        {
            InitializeComponent();


        slovar = new Dictionary<int, string>()
        {
        { 123456789, "Гарипов"},
        { 223456781, "Иванов"},
        { 334567890, "Петров"},
          { 434567890, "Байталов"},
            { 534567890, "Каримов"},
              { 634567890, "Павлова"},
                { 734567890, "Титов"},
                  { 834567890, "Горелов"},
                    { 934567890, "Матвеев"},
                      { 104567890, "Фомичев"}
        };
            
        }




        private void Button_Search(object sender, RoutedEventArgs e)
        {
          
            var key = Convert.ToInt32(txtbox1.Text);
            if (slovar.TryGetValue(key, out var value))
            {
                MessageBox.Show($"Значение для ключа {key}: {value}");
            }
            else
            {
                MessageBox.Show($"Ключ {key} не найден.");
            }
        }

        private void Button_result(object sender, RoutedEventArgs e)
        {

        }

        private void Button_remove(object sender, RoutedEventArgs e)
        {
            var key = Convert.ToInt32(txtbox1.Text);
            if (slovar.TryGetValue(key, out var value))
            {
                slovar.Remove(key);
                MessageBox.Show($"элемент ключа {key}: {value} удален");
            }
            else
            {
                MessageBox.Show($"Ключ {key} не найден.");
            }

        }

        private void Button_Export(object sender, RoutedEventArgs e)
        {
            foreach (var person in slovar)
            {
                slov.Text = person.ToString();
            }
        }
        private void Button_RemoveAll(object sender, RoutedEventArgs e)
        {
        
            slov.Clear(); // очищаем 
            slovar.Clear();
        }

        
    }
}
