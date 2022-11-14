using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWork
{
    /// <summary>
    /// Написать программу, которая из имеющегося массива из строк формирует массив из строк, 
    /// длинна которых меньше либо равна 3 символам. Первоначальный массив 
    /// можно ввести с клавиатуры, либо задать на старте выполнения аогоритма.
    /// </summary>
    public class ITOG
    {
        /// <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
        {
            string[] array1 = new string[5] { "ао", "ура", "hello", "11111", "907" };
            PrintArray(array1);
            string[] array2 = new string[array1.Length];

            void ArrayResult(string[] array1, string[] array2)
            {
                int count = 0;
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i].Length <= 3)
                    {
                        array2[count] = array1[i];
                        count++;
                    }
                }
            }
            void PrintArray(string[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]} ");
                }
                Console.WriteLine();
            }
            ArrayResult(array1, array2);
            PrintArray(array2);
        }
    }
}
