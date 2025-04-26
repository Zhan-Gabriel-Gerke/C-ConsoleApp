using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C_ConsoleApp
{
    class ArvuTreatment
    {
        public static void GeenereeriRuudud()
        {
            Random random = new Random();
            int a = random.Next(-100, 100);
            int b = random.Next(-100, 100);
            Console.WriteLine(a);
            Console.WriteLine(b);
            int min = Math.Min(a, b);
            int max = Math.Max(a, b);
            Console.WriteLine($"{min} {max}");
            int[] squares = new int[max - min + 1];
            /* int[] squares - Declaration of new array
             * new int[max - min + 1] - Creating of new array. The array can include difference between max and min and + 1
            /*if (a > b)
            {
                min = b;
                max = a;
            }
            else if (a < b)
            {
                min = a;
                max = b;
            }
            else
            {
                min = a;
                max = b;
            }*/
                for (int i = min; i <= max; i++)
                {
                squares[i - min] = i * i;
                Console.WriteLine(i * i);
                /* squares[i - min] - Insert to the array by index starts from 0
                 * example min = 200 i=200(Because it takes value of min)min(200)-i(200)=0 -index
                 * i * i = Makes a squer of number
                 */
                }
            //Console.WriteLine(squares);
            //return squares;
        }
        /*public sint Times = int.Parse(Console.ReadLine());tatic double[] Text_figures(int[] array)
        {
            double[] doubleArray = new double[array.Length];//Создание нового масива такой же длинны как и масив array при помощи(.Length)
            for (int i = 0; i < array.Length; i++)
            {
                doubleArray[i] = (double)array[i];
            }
            return doubleArray;
        }*/
        public static double[] Text_figures()
        {
            Console.Write("Enter how many numbers do you want to enter numbers: ");
            int Times = int.Parse(Console.ReadLine());// int.Parse() - Преобразует string в int (если ввести не int выдаст ошибку "FormatException")
            double[] doubleArray = new double[Times];
            for (int i = 0; i < Times; i++)
            {
                Console.WriteLine($"Enter number nr {i}: ");
                int number = int.Parse(Console.ReadLine());
                doubleArray[i] = number;
            }
            return doubleArray;
        }
        public static (double, double, double) AnaluusiArve(double[] doubleArray)
        {
            // int i=0 декларирует переменную присваивает тип и значение
            // i < doubleArray.Length - Условие при котором работает цикл. Пока i меньше длинны Масива
            // i++ - увеличивает i на 1 после каждой итерации (Итерация - повторение процеса до достижения результата)
            //
            double summa = doubleArray[0];
            double avg = doubleArray[0];
            double summa3 = doubleArray[0];
            for (int i = 1; i < doubleArray.Length;i++)
            {
                summa = summa + doubleArray[i];
                avg = avg + doubleArray[i];
                summa3 = summa3 * doubleArray[i];
                Console.WriteLine(summa + avg + summa3);
            }
            avg = avg / doubleArray.Length;
            return (summa, avg, summa3);
        }
    }
}
