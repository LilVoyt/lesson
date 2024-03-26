using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex 1
            //Console.WriteLine("It's easy to win forgiveness for being wrong;\nbeing right is what gets you into real trouble.\nBjarne Stroustrup");
            //Ex 2
            //int num = 5;
            //int[] arr = new int[num];
            //for(int i = 0; i < num; i++)
            //{
            //    Console.Write($"Enter \'{i}\' number: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Enter what you want(0 - sum, 1 - max and min, 2 - multiply)");
            //int choose = int.Parse(Console.ReadLine());

            //switch (choose)
            //{
            //    case 0:
            //        int count = 0;
            //        for (int i = 0; i < num; i++)
            //        {
            //            count += arr[i];
            //        }
            //        Console.WriteLine($"Sum of all numbers is {count}");
            //        break;
            //    case 1:
            //        int max = arr[0];
            //        int min = arr[0];
            //        for( int i = 0; i < num; i++)
            //        {
            //            if(arr[i] > max)
            //            {
            //                max = arr[i];
            //            }
            //        }
            //        for (int i = 0; i < num; i++)
            //        {
            //            if (arr[i] < min)
            //            {
            //                min = arr[i];
            //            }
            //        }
            //        Console.WriteLine($"Min number in our array is: {min}");
            //        Console.WriteLine($"Max number in our array is: {max}");
            //        break;
            //    case 2:
            //        int multiply = 1;
            //        for (int i = 0; i < num; i++)
            //        {
            //            multiply *= arr[i];
            //        }
            //        Console.WriteLine($"Multiply of all numbers is {multiply}");
            //        break;
            //}
            //Console.ReadKey();

            //Ex3
            //Console.WriteLine("Enter the number of 6 digits: ");
            //string number_str = Console.ReadLine();
            //number_str = new string(number_str.Reverse().ToArray());
            //int number = int.Parse(number_str);
            //Console.WriteLine(number);

            //Ex4
            //Console.WriteLine("Enter the diapasone of fibonacci numbers:");
            //Console.Write("from: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("to: ");
            //int b = int.Parse(Console.ReadLine());

            //int num1 = 0;
            //int num2 = 1;
            //int temp;

            //while (num1 <= b)
            //{
            //    if (num1 >= a)
            //    {
            //        Console.Write($"{num1} ");
            //    }

            //    temp = num2;
            //    num2 = num1 + num2;
            //    num1 = temp;
            //}
            //Console.ReadLine();


            //Ex5
            //int a = 4;
            //int b = 9;
            //for (int i = a; i <= b; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write(i);
            //    }
            //    Console.Write("\n");
            //}

            //Ex6
            //Console.Write("Enter the length of row: ");
            //int length = int.Parse(Console.ReadLine());
            //Console.Write("Enter the sub: ");
            //char ch = Console.ReadKey().KeyChar;
            //Console.Write("\n");
            //Console.WriteLine("Choose orientation of row: (0 - gorizotnally, 1 - vertically)");
            //int choose = int.Parse(Console.ReadLine());
            //switch (choose)
            //{
            //    case 0:
            //        for (int i = 0; i < length; i++)
            //        {
            //            Console.Write($"{ch} ");
            //        }
            //        break;
            //    case 1:
            //        for (int i = 0; i < length; i++)
            //        {
            //            Console.WriteLine(ch);
            //        }
            //        break;
            //}
        }
    }
}
