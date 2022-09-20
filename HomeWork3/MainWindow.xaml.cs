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

namespace HomeWork2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string Cheesar(string text, int d)
        {
            int nomer; // Номер в алфавите
            string s; //Результат
            int shift;
            int j; // Переменная для циклов

            char[] massage = text.ToCharArray(); // Превращаем строку в массив символов.

            char[] alfavit = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };

            // Перебираем каждый символ сообщения
            for (int i = 0; i < massage.Length; i++)
            {
                // Ищем индекс буквы
                for (j = 0; j < alfavit.Length; j++)
                {
                    if (massage[i] == alfavit[j])
                    {
                        break;
                    }
                }

                if (j != 33) // Если j равно 33, значит символ не из алфавита
                {
                    nomer = j; // Индекс буквы
                    shift = nomer + d; // Делаем смещение

                    // Проверяем, чтобы не вышли за пределы алфавита
                    while (shift > 32)
                    {
                        shift -=  33;
                    }

                    massage[i] = alfavit[shift]; // Меняем букву
                }
            }

            return s = new string(massage); // Собираем символы обратно в строку.
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Click_1(object sender, RoutedEventArgs e)
        {
            string text = EditText.Text;
            int shift = int.Parse(EditShift.Text);

            if (text != "" & shift >= 0)
            {
                string result = Cheesar(text.ToLower(), shift);

                LblFinal.Content = result;
            } else
            {
                LblFinal.Content = "Введены неправильные данные!";
            }
        }
    }
}
