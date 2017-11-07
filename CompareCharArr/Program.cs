using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArr
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arr = new List<string>();
           
            for (int i = 0; i < 2; i++)
            {
                arr.Add(Console.ReadLine());
            }
            if (arr[0].CompareTo(arr[1])==0)
            {
                Console.WriteLine("=");
            }
            else if(arr[0].CompareTo(arr[1])==-1)
            {
                Console.WriteLine("<");
            }
            else if(arr[0].CompareTo(arr[1])==1)
            {
                Console.WriteLine(">");
            }
            
           
           
        }
    }
}
