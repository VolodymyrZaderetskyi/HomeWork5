using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace HomeWork5
{
    class Program
    {
        // Володимир Задерецький 
        /*
          1. Создать программу, которая будет проверять корректность ввода логина. 
             Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры,
             при этом цифра не может быть первой:
               а) без использования регулярных выражений;
          2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
                а) Вывести только те слова сообщения,  которые содержат не более n букв.
                б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
                в) Найти самое длинное слово сообщения.
                г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
         */
        public static bool LoginCheck(string login)
        {
            bool okLog = false;
            if (!Char.IsDigit(login[0]) && (login.Length > 1) && (login.Length <= 10))
            {
                okLog = true;
                for (int i = 0; i < login.Length; i++)
                {
                    if (((login[i] >= 'A') && (login[i] <= 'Z')) || ((login[i] >= 'a') && (login[i] <= 'z')) || ((login[i] >= '0') && (login[i] <= '9')))
                    {
                        continue;
                    }
                    else
                    {
                        okLog = false;
                        break;
                    }
                }
            }
            return okLog;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter login:");
            string login = Console.ReadLine();
            
             if (LoginCheck(login))
             {
                 Console.WriteLine("Ok");
             }
             else
             {
                 Console.WriteLine("Not Ok");
             }
            
            Console.WriteLine(Message.WordsShorterThan(login, 6));
            Console.WriteLine(Message.DeleteAllWordsWith(login, 'f'));
            Console.WriteLine(Message.DeleteAllWordsWith(login, 'f'));
            Console.WriteLine(Message.LongestWord(login));
            Console.WriteLine(Message.AllLongestWord(login));
        }
    }
}
