using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kl_praktic_massiv_stroki_3
{
    class Program
    {
        static int min;
        static int max;
        static void Main(string[] args)
        {
            FirstTask();
            SecondTask();
            ThirdTask();
            FourthTask();
            FifthTask();
        }
        static protected void FirstTask()
        {
            Console.WriteLine("1.Объявить одномерный (5 элементов ) массив с именем " +
                "A и двумерный массив (3 строки, 4 столбца) дробных чисел с именем B." +
                " Заполнить одномерный массив А числами, введенными с клавиатуры " +
                "пользователем, а двумерный массив В случайными числами с помощью циклов. Вывести на экран значения массивов: массива А в одну строку, массива В — в виде матрицы. Найти в данных массивах общий максимальный элемент, минимальный элемент, общую сумму всех элементов, общее произведение всех элементов, сумму четных элементов массива А, сумму нечетных столбцов массива В.");
            int sizeA = 5;
            int[] A = new int[sizeA];
            int sizeBcol = 4;
            int sizeBrow = 3;
            //double[][] B = new double[sizeBrow][];
            double[,] B = new double[sizeBrow, sizeBcol];
            Console.WriteLine("введите значения массива: ");
            for (int i = 0; i < sizeA; i++)
            {
                //Console.WriteLine("A["+i+"]");
                Console.Write("A[" + i + "]= ");
                A[i] = int.Parse(Console.ReadLine());
            }
            Random random = new Random((int)DateTime.Now.Ticks);
            min = 1;
            max = 100;
            int min1 = 1;
            int max1 = 10;
            for (int i = 0; i < sizeBrow; i++)
            {
                for (int j = 0; j < sizeBcol; j++)
                {
                    B[i, j] = (double)random.Next(min, max) / random.Next(min1, max1);
                    Console.Write("B[" + i + "]" + "[" + j + "]: " + B[i, j] + "  ");
                }
                Console.WriteLine();
            }
            double maxB = B[0, 0];
            double minB = B[0, 0];
            double Sum = 0;
            double SumChet = 0;
            double SumNeChet = 0;
            foreach (var a in B)
            {
                if (maxB < a) maxB = a;
                if (minB > a) minB = a;
                Sum += a;
                if (a % 2 == 0) SumChet += a;
                else SumNeChet += a;
            }
            foreach (var a in A)
            {
                if (maxB < a) maxB = a;
                if (minB > a) minB = a;
                Sum += a;
            }
            Console.WriteLine("Максимальный элемент= " + maxB);
            Console.WriteLine("Минимальный элемент= " + minB);
            Console.WriteLine("сумма всех элементов: " + Sum);
            Console.WriteLine("сумма четных элементов: " + SumChet);
            Console.WriteLine("сумма нечетных элементов: " + SumNeChet);
            Console.WriteLine(".....нажмите любую кнопочку для продлжения работы");
            Console.ReadKey();
            Console.Clear();
        }
        static private void SecondTask()
        {
            Console.WriteLine("2.Даны 2 массива размерности M и N соответственно." +
                " Необходимо переписать в третий массив общие элементы первых двух" +
                " массивов без повторений.");
            Console.WriteLine("введите размер первого массива: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("введите размер второго массива: ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers1 = new int[m];
            int[] numbers2 = new int[n];
            // int count = 0;
            int i3 = 0;
            int sizeNumbers3 = m * n;
            int[] numbers3 = new int[sizeNumbers3];
            for (int i = 0; i < m; i++)
            {
                Console.Write("numbers1[" + i + "]= ");
                numbers1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("numbers2[" + i + "]= ");
                numbers2[i] = int.Parse(Console.ReadLine());
                foreach (var a in numbers1)
                {
                    if (a == numbers2[i])
                    {
                        numbers3[i3] = numbers2[i];
                        i3++;
                    }
                }
            }
            int[] numbers3_final = new int[i3];
            int i3f = 0;
            bool isNumber;
            foreach (var a in numbers3)
            {
                isNumber = false;
                for (int i = 0; i < i3f; i++)
                {
                    if (a == numbers3_final[i]) isNumber = true;
                }
                if (isNumber == false)
                {
                    numbers3_final[i3f] = a;
                    i3f++;
                }
            }
            int[] numbers_result = new int[i3f - 1];
            for (int i = 0; i < i3f - 1; i++)
                numbers_result[i] = numbers3_final[i];
            Console.Write("одинаковые значения массива: ");
            foreach (var a in numbers_result)
            {
                Console.Write(a + "  ");
            }
            Console.WriteLine(".....нажмите любую кнопочку для продлжения работы");
            Console.ReadKey();
            Console.Clear();

        }
        static private void ThirdTask()
        {
            Console.WriteLine("3.Пользователь вводит строку. Проверить, является ли эта" +
                " /nстрока палиндромом. Палиндромом называется строка, которая одинаково" +
                " \nчитается слева направо и справа налево.");

            Console.Write("введите длину массива: ");
            var size = int.Parse(Console.ReadLine());
            int[] mas = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("mas[" + i + "]= ");
                mas[i] = int.Parse(Console.ReadLine());
            }


            Console.Write("\nmas: ");
            foreach (var a in mas)
            {
                Console.Write(a);
            }


            Console.WriteLine();
            int[] mas2 = new int[size];
            Array.Copy(mas, mas2, size);
            Array.Reverse(mas2);

            Console.Write("mas2: ");
            foreach (var a in mas2)
            {
                Console.Write(a);
            }
            Console.WriteLine("\n");

            int index2 = 0;
            bool result = true;
            foreach (var a in mas)
            {
                if (a != mas2[index2]) result = false;
                index2++;
            }

            if (result == false) Console.WriteLine("не полиндром!");
            else Console.WriteLine("полиндром!");

            Console.WriteLine(".....нажмите любую кнопочку для продлжения работы");
            Console.ReadKey();
            Console.Clear();

        }
        static private void FourthTask()
        {
            Console.WriteLine("4.Подсчитать количество слов во введенном предложении");
            Console.WriteLine("введите предложения: ");

            string str = Console.ReadLine();
            string strTrim = str.Trim();
            Console.WriteLine(strTrim);
            int cnt = 0;
            //mama poslala   za   hlebom//
            for (int i = 0; i < strTrim.Length - 1; i++)
            {
                if (strTrim[i] != ' ' && strTrim[i + 1] == ' ') cnt++;
            }
            if (cnt > 0) cnt++;
            Console.WriteLine("количество слов: " + cnt);
        }
        static private void FifthTask()
        {
            Console.WriteLine("5.Дан двумерный массив размерностью 5?5, заполненный " +
                "\nслучайными числами из диапазона от –100 до 100. Определить сумму " +
                "\nэлементов массива, расположенных между минимальным и максимальным " +
                "элементами.");
            int col = 5, row = 5;
            int[,] mas = new int[row, col];
            int min = -100, max = 100;
            Random rand = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    mas[i, j] = rand.Next(min, max);
                    Console.Write(mas[i, j] + "  ");
                }
                Console.WriteLine();
            }
            min = max = mas[0, 0];
            int sum = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (mas[i, j] > max) max = mas[i, j];
                    if (mas[i, j] < min) min = mas[i, j];
                }
            }
            bool isFirstMax = true;
            bool isExit = false;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (mas[i, j] == max) { isFirstMax = true; isExit = true; break; }
                    if (mas[i, j] == min) { isFirstMax = false; isExit = true; break; }
                }
                if (isExit == true) break;
            }
            bool isBeginSum = false;
            if (isFirstMax == true)
                foreach (var a in mas)
                {
                    if (a == max) isBeginSum = true;
                    if (isBeginSum == true) sum += a;
                    if (a == min) break;
                }
            else
            {
                foreach (var a in mas)
                {
                    if (a == min) isBeginSum = true;
                    if (isBeginSum == true) sum += a;
                    if (a == max) break;
                }
            }
            Console.WriteLine("max:" + max + " min: " + min);
            sum -= (min + max);
            Console.WriteLine("сумма элементов между максимальной и минимальной значениями массива равна= " + sum);
        }
    }
}



