using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        public static int ReadInteger()
        //ввод числа для красивых лаб
        {
            bool check = false;
            int IntNum;
            do
            {
                // Попытка перевести строку в число
                check = Int32.TryParse(Console.ReadLine(), out IntNum);
                // Если попытка неудачная:
                if (!check)
                    Console.WriteLine("Некорректный ввод. Попробуйте ещё раз");
            } while (!check);
            // Если попытка удачная:
            return IntNum;
        }



        public static int ReadNatural()
        //ввод числа для красивых лаб
        {
            bool check = false;
            int intNum;
            do
            {
                // Попытка перевести строку в число
                check = Int32.TryParse(Console.ReadLine(), out intNum);
                // Если попытка неудачная:
                if (!check)
                    Console.WriteLine("Некорректный ввод. Попробуйте ещё раз");
            } while (!check);
            // Если попытка удачная:
            return intNum;
        }
        static void Sequence(int a1, int a2, int a3, int N, int M, ref bool ok, int count, int countThree)
        {
            int buf = a3;
            if (ok) return;
            a3 = 2 * Math.Abs(a3 - a2) + a1;
            if (a3 % 3 == 0) countThree++;
            count++;
            if (N == M)
            {
                Console.WriteLine("Программа остановилась из-за нахождения одинаковых элементов N и M");
                ok = true;
                return;
            }
            if (M == countThree && M > 0)
            {
                Console.WriteLine("Программа остановилась из-за нахождения M элементов.");
                ok = true;
                return;
            }
            if (N == count)
            {
                Console.WriteLine("Программа остановилась из-за достижения N элементов.");
                ok = true;
                return;
            }
            a1 = a2;
            a2 = buf;
            Sequence(a1, a2, a3, N, M, ref ok, count, countThree);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a1");
            int a1 = ReadInteger();
            Console.WriteLine("Введите a2");
            int a2 = ReadInteger();
            Console.WriteLine("Введите a3");
            int a3 = ReadInteger();
            Console.WriteLine("Введите натуральное N");
            int N = ReadNatural();
            Console.WriteLine("Введите натуральное M");
            int M = ReadNatural();
            Console.WriteLine("a1={0} a2={1} a3={2} N={3} M={4} ", a1, a2, a3, N, M);
            bool k = false;
            Sequence( a1, a2, a3, N, M, ref  k,0,0);


        }
    }
}