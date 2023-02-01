using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._02._23_HW_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Задание 1
            Console.WriteLine("Task 1 \n");
            Console.WriteLine("It's easy to win forgiveness for being wrong;");
            Console.WriteLine("being right is what gets you into real trouble.");
            Console.WriteLine("Bjarne Stroustrup\n");
            #endregion

            #region Задание 2
            Console.WriteLine("\nTask 2 \n");
            int[] num = new int[5];
            Console.WriteLine("Write 5 num: ");
            for(int i = 0; i < num.Length; i++)
                num[i] = Convert.ToInt32(Console.ReadLine());
            int sum = 0, multi = 1, min = num[0], max = num[0];
            for (int i = 0; i < num.Length; i++)
            {
                if(min > num[i])
                    min = num[i];
                if(max < num[i])
                    max = num[i];
                multi *= num[i];
                sum += num[i];
            }
            Console.WriteLine($"Sum = {sum}\nMulti = {multi}\nMin = {min}  Max = {max}\n");
            #endregion

            #region Задание 3
            Console.WriteLine("\nTask 3 \n");
            string buf = Console.ReadLine();
            Console.Write("Reverse: ");
            for (int i = buf.Length - 1; i >= 0; i--)
                Console.Write($"{buf[i]}");
            Console.WriteLine("\n");
            #endregion

            #region Задание 4
            Console.WriteLine("\nTask 4 \n");
            int last_one = 0, last_two = 1;
            Console.Write("Lim: ");
            int limit = Convert.ToInt32(Console.ReadLine());
            Console.Write($"{last_one} {last_two} ");
            int last_buf;
            while(true)
            {
                if (last_one + last_two > limit)
                    break;
                last_buf = last_two;
                last_two = last_one + last_two;
                last_one = last_buf;
                Console.Write($"{last_two} ");
            }
            Console.WriteLine("\n");
            #endregion

            #region Задание 5
            Console.WriteLine("\nTask 5 \n");
            Console.Write("Write min: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write max: ");
            int B = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < B - A + 1; i++)
            {
                for (int j = 0; j < A + i; j++)
                    Console.Write($"{A + i}");
                Console.WriteLine();
            }
            #endregion

            #region Задание 6
            Console.WriteLine("\nTask 6 \n");
            Console.WriteLine("\n1 - Vertical, 2 - Horizontal");
            int type = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nChar: ");
            string buf_char = Console.ReadLine();
            Console.Write("Count: ");
            int count = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < count; i++)
            {
                if (type == 1)
                    Console.WriteLine($"{buf_char}");
                else
                    Console.Write($"{buf_char}");
            }
            Console.WriteLine();
            #endregion
        }
    }
}
