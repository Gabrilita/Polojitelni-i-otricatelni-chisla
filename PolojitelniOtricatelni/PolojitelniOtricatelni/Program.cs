using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolojitelniOtricatelni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число: ");
            List<int> positiveNumbers = new List<int>();
            List<int> negativeNumbers = new List<int>();
            int input = int.Parse(Console.ReadLine());
            while (input != 0)
            {
                if (input > 0)
                {
                    positiveNumbers.Add(input);
                }
                else
                {
                    negativeNumbers.Add(input);
                }
                Console.Write("Въведете число: ");
                input = int.Parse(Console.ReadLine());
            }
            positiveNumbers.Sort();
            negativeNumbers.Sort();
            Console.WriteLine("Списък с положителни числа:");
            foreach (int num in positiveNumbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Списък с отрицателни числа:");
            foreach (int num in negativeNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
