using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pakhomov.Task.Net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Задание 1
        private void button1_Click(object sender, EventArgs e)
        {
            // для сортировки можно использовать метод Array.Sort();
            // Создаем функцию сортировки
            static int[] Sort(int[] array)
            {
                int temp;
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] > array[j])
                        {
                            temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }
                return array;
            }
            // Программа для демонстрации работы функции
            int N = Int32.Parse(textBox2.Text);
            
            int[] array = new int[N];   // считываем количество чисел в массиве
            textBox3.Clear();
            String[] strarray = textBox1.Text.Split(' ');   // считываем числа массива
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(strarray[i]);
            }
            Sort(array); // вызываем функцию сортировки
            
            for (int i = 0; i < array.Length; i++)  // выводим отсортированный массив
            {
                textBox3.Text += array[i].ToString() + " ";
            }
            

            
        }
        // Задание 2
        private void button2_Click(object sender, EventArgs e)
        {
            int N = Int32.Parse(textBox2.Text);

            int[] array = new int[N];   // считываем количество чисел в массиве
            int num = Int32.Parse(textBox4.Text);   // считываем искомое число
            textBox5.Clear();
            String[] strarray = textBox3.Text.Split(' ');   // считываем числа массива
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(strarray[i]);
            }
            int x = 0;  // ищем число
            for (int i = 0; i < array.Length; i++)
            {
                
                if (num == array[i])
                {
                    x = 1;
                    break;
                }
                else
                {
                    x = 0;
                }
            }
            if ( x == 1)    // вывод результата поиска
            {
                textBox5.Text = "Данное число содержится в массиве";
            }
            else
            {
                textBox5.Text = "Данное число не содержится в массиве";
            }
        }
        // Задание 3
        private void button3_Click(object sender, EventArgs e)
        {
            String[] words = textBox6.Text.Split(new[] { '.', ',', ' ', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);   // считываем слова в массив
            textBox7.Clear();
            for (int i = 0; i < words.Length; i++)  // производим поиск
            {
               String word = words[i];
                int count = 0;
                foreach (string item in words)
                {
                    if (item == word)
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    textBox7.Text += words[i] + " ";    // вывод слов
                }
            }
        }
        // Задание 4
        private void button4_Click(object sender, EventArgs e)
        {
            textBox9.Clear();
            int n = Int32.Parse(textBox8.Text);
            int factorial = 1;  // значение факториала

            for (int i = 2; i <= n; i++)    // цикл начинаем с 2, т.к. нет смысла начинать с 1
            {
                factorial = factorial * i;
            }
            textBox9.Text = factorial.ToString();   // вывод результата
        }
        // Задание 5
        private void button5_Click(object sender, EventArgs e)
        {
            String str = textBox10.Text;    // считываем строку
            Char[] ch = str.ToCharArray();  // разбиваем на массив char
            int check_bracket = 0;
            for (int i = 0; i < ch.Length; i++) // производим проверку последовательности
            {
                if (check_bracket < 0)
                {
                    textBox11.Text = "Последовательность неправильная";
                    break;
                }
                foreach (char one_symbol in ch)
                {
                    if (one_symbol == '(')
                    {
                        check_bracket++;
                    }
                    else
                    {
                        if (one_symbol == '[')
                        {
                            check_bracket++;
                        }
                        else
                        {
                            if (one_symbol == '{')
                            {
                                check_bracket++;
                            }
                            else
                            {
                                check_bracket--;
                            }
                        }
                    }
                }
                
            }
            if (check_bracket == 0)
            {
                textBox11.Text = "Последовательность правильная";
            }
            else
            {
                textBox11.Text = "Последовательность неправильная";
            }
        }
    }
}
