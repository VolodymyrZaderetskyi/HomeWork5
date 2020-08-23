using System;
using System.IO;

namespace HomeWork6
{
    public delegate double Fun(double x);
    public delegate double FunTwo(double x, double y); 
    class Program
    {
        /*
                Володимир Задерецький
                   1. Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). 
                      Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
                   2.Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата. 
                        б) *Переделать функцию Load, чтобы она возвращала массив считанных значений.
                        Пусть она возвращает минимум через параметр (с использованием модификатора out). 
         */





        public static double F(double x)
        {
            return x * x - 50 * x + 10;
        }






        public static void Table(Fun F, double x, double b)
            {
                Console.WriteLine("----- X ----- Y -----");
                while (x <= b)
                {
                    Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x));
                    x += 1;
                }
                Console.WriteLine("---------------------");
            }
        public static void Table(FunTwo F, double x, double y, double b)
        {
            Console.WriteLine("----- X ---------- Y ----- F(x,y) ");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000} |", x, y, F(x,y));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        public static double MyFunc(double x)
            {
                return x * x * x;
            }

        public static double MyFunc(double x,double y)
        {
            return y * x * x;
        }

        public static double MyFuncSin(double x, double y)
        {
            return y * Math.Sin(x);
        }

        static void Main(string[] args)
            {
            Console.WriteLine("Таблица функции x^3:");
            Table(MyFunc, -2, 2);
            Console.WriteLine("Таблица функции y*x^2:");
            Table(MyFunc, -2, 3, 2);
            Console.WriteLine("Таблица функции y*Sin(x):");
            Table(MyFuncSin, -2, 3, 2);

            Console.WriteLine("Минимальное значение функции F(x):");
            MinFun.SaveFunc("data.bin", F, -100, 100, 0.5);
            double min;
            MinFun.Load("data.bin",out min);
            Console.WriteLine(min.ToString());
        }
        
    }
}
