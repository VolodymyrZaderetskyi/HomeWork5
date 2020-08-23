using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork8
{
    static class Program
    {
        /*
                Володимир Задерецький

                1. С помощью рефлексии выведите все свойства структуры DateTime
                2. Создайте простую форму на котором свяжите свойство Text элемента 
                   TextBox со свойством Value элемента NumericUpDown

         */
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
