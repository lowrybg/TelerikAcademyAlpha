using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//UNSOLVED
namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int[] newArr = new int[n];

            int minim = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                int j = 0;
               while(j<numbers.Length-1)
                {
                    if(numbers[j]<numbers[j+1])
                    {
                        if (minim > numbers[j])
                        {
                            minim = numbers[j];
                        }
                    }
                    j ++;
                }
                numbers[i] = minim;
                minim = int.MaxValue;
                j += 1;

            }

            foreach (var item in newArr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
