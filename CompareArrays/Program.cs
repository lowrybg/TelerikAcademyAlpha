﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr1[i]= int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());

            }
            bool equal = true;
            for (int i = 0; i < n; i++)
            {
                if(arr1[i]!=arr2[i])
                {

                    equal = false;
                }
                
               
            }
            Console.WriteLine(equal==true?"Equal": "Not equal");
           
        }





        //private static int FillArr(int n)
        //{
        //    int[] arr = new int[n];
        //    for (int i = 0; i < n; i++)
        //    {
        //       arr[i] = int.Parse(Console.ReadLine());
        //    }
           
        //}
    }
}
