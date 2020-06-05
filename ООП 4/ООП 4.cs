using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_4
{
    //задание 1
    class Health
    {
        private int temperature;
        public int Temp
        {
            get
            {
                return temperature;
            }
            set
            {
                if (value < 34)
                {
                    temperature = 34;
                    Console.WriteLine("Введеное Вами значение находится вне диапозона," + " поэтому автоматически было присвоено максимальное значение из заданного диапазона");
                }

                else
                if (value > 41)
                {
                    temperature = 41;
                    Console.WriteLine("Введеное вами значение находится вне диапозона," + " поэтому автоматически присвоено максимальное значение из заданного диапазона");
                }
                else temperature = value;
            }
        }
    }

    //задание 2
    class Book
    {
        private int releaseYear;
        public int ReleaseYear
        {
            get
            {
                return releaseYear;
            }
            set
            {

                if (value < 1940)
                {
                    releaseYear = 1940;
                    Console.WriteLine("Введеное вами значение находится вне диапозона," + " поэтому автоматически присвоено минимальное значение из заданного диапазона");
                }

                else
                if (value > 2020)
                {
                    releaseYear = 2020;
                    Console.WriteLine("Введеное вами значение находится вне диапозона," + " поэтому автоматически присвоено максимальное значение из заданного диапазона");
                }
                else releaseYear = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Health newH = new Health();

        link1:
            Console.WriteLine("Введите температуру тела от 34 до 41");
            try
            {
                newH.Temp = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Температура равна " + newH.Temp);
            }
            catch
            {
                Console.WriteLine("Некорректный тип данных"); goto link1;
            }
            Console.WriteLine();
            Console.WriteLine("<<------------------------------------>>");
            Console.WriteLine();

            Book newB = new Book();

        link2:
            Console.WriteLine("Введите год выпуска от 1940 до 2020");
            try
            {
                newB.ReleaseYear = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Год выпуска - " + newB.ReleaseYear);
            }
            catch
            { 
                Console.WriteLine("Некорректный тип данных"); goto link2; 
            }
            Console.ReadKey();
        }
    }
}
