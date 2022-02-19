using System;

namespace hhTestingtask
{
    internal class Program
    {
        private static int[][] GetRandArrays(int n) // Создание массива с n-количеством массивов, присвоение им рандомного размера и наполнения в заданных диапазонах
        {
            int[][] arrays = new int[n][];
            Random rnd = new Random();
            int amountOfArrays;
            int value;
            for (int i = 0; i < n; i++)
            {
                amountOfArrays = rnd.Next(5, 20);
                arrays[i] = new int[amountOfArrays];

                for (int j = 0; j < arrays[i].Length; j++)
                {
                    arrays[i][j] = rnd.Next(-35, 35);
                }
            }
            return arrays;
        }
        private static void SortDownUpArray(int[] ints) // Cортировка по возрастанию
        {
            for (var i = 0; i < ints.Length; i++)
            {
                for (var j = i + 1; j < ints.Length; j++)
                {
                    if (ints[i] > ints[j])
                    {
                        (ints[i], ints[j]) = (ints[j], ints[i]);
                    }
                }
            }
        }
        private static void SortUpDownArray(int[] ints) // Сортировка по убыванию
        {
            for (var i = 0; i < ints.Length; i++)
            {
                for (var j = i + 1; j < ints.Length; j++)
                {
                    if (ints[i] < ints[j])
                    {
                        (ints[i], ints[j]) = (ints[j], ints[i]);
                    }
                }
            }

        }
        private static void Sort2dArray(int[][] array) // Общая функция с условием для применения сортировок
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    SortDownUpArray(array[i]);
                }
                else
                {
                    SortUpDownArray(array[i]);
                }
            }
        }
        private static void Print2dArray(int[][] array) //Вывод массива массивов
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество массивов: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[][] array = GetRandArrays(n);
            Sort2dArray(array);
            Print2dArray(array);

        }
    }
}
