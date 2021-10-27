using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Zadanie22
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество подсчитываемых элементов");
            int r = Convert.ToInt32(Console.ReadLine());
            int[] arrayName = new int[r];
            var rand = new Random();
            for (int i = 0; i < r; i++)
            {
                arrayName[i] = rand.Next();
                Console.WriteLine(arrayName[i]);
            }
            int max = MaximValue(arrayName);
            int summ = SummValue(arrayName);
            
            Task<int> task1 = new Task<int>(() => max);
            Task<int> task2 = new Task<int>(() => summ);

            Console.ReadKey();



        }

        public static int MaximValue(int [] array)
        {
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            Console.WriteLine("Максимальное значение =" + max);
            return max;
        }

        public static int SummValue(int[] array)
        {
            int Sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Sum += array[i];
            }
            Console.WriteLine("Сумма=" + Sum);
            return Sum;
        }
    }
}
