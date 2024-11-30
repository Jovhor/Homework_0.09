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

namespace Homework_0._09
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Training(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Обучение.\n" +
                "Введи предложение. Нажми на первую кнопку. Должны выйти слова.");
        }

        private void Button_Click_Divide(object sender, RoutedEventArgs e)
        {
            string str = tb_Revers.Text;
            string[] words = str.Split(' ');
            string reversedWords = string.Join(" ", words.Reverse());
            l_Revers.Content = reversedWords;
            l_Revers.Visibility = Visibility.Visible;
        }

        private void Button_Click_Shufle(object sender, RoutedEventArgs e)
        {
            string strSplit = tb_Split.Text;
            string[] words = strSplit.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Если не надо перезаписывать данные листбокса
            //lb_Split.ItemsSource = words;

            foreach (string word in words)
            {
                lb_Split.Items.Add(word);
            }
        }

        private void tb_Split_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Button_Click_Shufle(sender, e);
            }
        }

        private void tb_Revers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Button_Click_Divide(sender, e);
            }
        }
    }
}
