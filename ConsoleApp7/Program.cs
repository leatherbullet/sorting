using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int minValue = 0;
            int maxValue = 10;
            int sizeArray = 10;
            int temp;
            int[] numbers = new int[sizeArray];

            for (int i = 0; i < sizeArray; i++)
            {
                numbers[i] = random.Next(minValue,maxValue);
                Console.Write(numbers[i] + " ");
            }

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for(int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("\n " + numbers[i] );
            }
        }
    }
}
