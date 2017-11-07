using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxK
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
          
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            numbers = numbers.OrderByDescending(c => c).ToArray();
            int sum = 0;
            for (int i = 0; i < k; i++)
            {

                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
    }


}
