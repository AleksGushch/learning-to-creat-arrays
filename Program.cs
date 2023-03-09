using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengthArray;
            int widthArray;
            int sum=0;
            Random random= new Random();

            Console.Write("Введите длину массива: ");
            lengthArray=int.Parse(Console.ReadLine());
            Console.Write("Введите ширину массива: ");
            widthArray= int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Первая матрица");
            int[,] firstArray = new int[lengthArray, widthArray];
            int[,] secondArray = new int[lengthArray, widthArray];
            int[,] sumArray = new int[lengthArray,widthArray];

            for (int i = 0; i < lengthArray; i++)
            {
                for (int j= 0; j < widthArray; j++)
                {
                    firstArray[i, j] = random.Next(10);
                    sum += firstArray[i, j];
                    Console.Write($"{firstArray[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Общая сумма чисел в матрице: {sum}");
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("Вторая матрица");
            for (int i = 0; i < lengthArray; i++)
            {
                for (int j = 0; j < widthArray; j++)
                {
                    secondArray[i, j] = random.Next(10);
                    Console.Write($"{secondArray[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Сумма обеих матриц");
            for (int i = 0; i < lengthArray; i++)
            {
                for (int j = 0; j < widthArray; j++)
                {
                    sumArray[i, j] = firstArray[i, j] + secondArray[i, j];
                    Console.Write($"{sumArray[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
