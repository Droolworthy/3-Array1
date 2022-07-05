using System;

namespace CS20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 2, 2, 2, }, { 3, 3, 3, }, { 4, 4, 4, } };
            int sum;
            int composition;

            Console.WriteLine("Вывод двухмерного массива: ");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();         
            }
            Console.WriteLine("Сумма второй строки массива: ");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum = array[1, 1] + array[1, 1] + array[1, 1];
                    Console.Write(sum + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Произведение первого столбца массива: ");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    composition = array[0, 0] * array[0, 0] * array[0, 0];
                    Console.Write(composition + " ");
                }
                Console.WriteLine();
            }
        }
    }
}