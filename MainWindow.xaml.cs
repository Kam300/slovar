using System;
using System.Collections.Generic;
using System.Windows;

namespace WpfApp21
{
    public partial class MainWindow : Window
    {
        private Dictionary<int, string> slovar;

        public MainWindow()
        {
            InitializeComponent();

            slovar = new Dictionary<int, string>()
            {
                { 1, "Гарипов"},
                { 2, "Иванов"},
                { 3, "Петров"},
                { 4, "Байталов"},
                { 5, "Каримов"},
                { 6, "Павлова"},
                { 7, "Титов"},
                { 8, "Горелов"},
                { 9, "Матвеев"},
                { 10, "Фомичев"}
            };
        }

        private void Button_Search(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtbox1.Text, out var key))
            {
                if (slovar.TryGetValue(key, out var value))
                {
                    MessageBox.Show($"Значение для ключа {key}: {value}");
                }
                else
                {
                    MessageBox.Show($"Ключ {key} не найден.");
                }
            }
            else
            {
                MessageBox.Show("Введите корректный числовой ключ.");
            }
        }

        private void Button_remove(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtbox1.Text, out var key))
            {
                if (slovar.TryGetValue(key, out var value))
                {
                    slovar.Remove(key);
                    MessageBox.Show($"Элемент с ключом {key}: {value} удалён.");
                }
                else
                {
                    MessageBox.Show($"Ключ {key} не найден.");
                }
            }
            else
            {
                MessageBox.Show("Введите корректный числовой ключ.");
            }
        }

        private void Button_Export(object sender, RoutedEventArgs e)
        {
            slov.Text = ""; // очищаем текстовое поле
            foreach (var person in slovar)
            {
                slov.Text += $"{person.Key}: {person.Value}\n"; // добавляем каждый элемент с переносом строки
            }
        }

        private void Button_RemoveAll(object sender, RoutedEventArgs e)
        {
            slovar.Clear(); // очищаем словарь
            slov.Text = ""; // очищаем текстовое поле
            MessageBox.Show("Все элементы удалены.");
        }
    }
}
