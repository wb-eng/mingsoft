using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_case9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i= 1; i<=9 ; i++)
            {
                for (int j=1; j<=i; j++)
                {
                    Console.Write("{0}*{1}={2} ", j, i, j*i);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
