using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iSum = 0;
            for (int iNum=1; iNum<=100; iNum++)
            {
                iSum += iNum;
            }
            Console.WriteLine(iSum);
            Console.ReadLine();
        }
    }
}
