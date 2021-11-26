/********************************************************************************************************/
/* file Name: Prime Number.sln                                                                          */
/* file info: This file for check the prime number.                                                     */
/* version  : V1.0                                                                                      */
/* Date     : 20 Nov021                                                                                 */
/* Author   : Ahmed Zoher                                                                               */
/********************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Prime_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.Write("---> Enter the Number to check Prime: ");
            int n = int.Parse(Console.ReadLine());
            int m = n / 2;
            for (int i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("\n\t---> [Number is not Prime] <---");
                    count = 1;
                    break;
                }
            }
            if (count == 0)
                Console.Write("\n\t---> [Number is Prime] <---");
        }
    }
}
