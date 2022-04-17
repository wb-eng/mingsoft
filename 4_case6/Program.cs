using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_case6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iNum = 1;
            int iSum = 0;
            while (iNum <=100)
            {
                iSum += iNum;
                iNum++;
            }

            Console.WriteLine(iSum);
            Console.ReadLine();
        }
    }
}
