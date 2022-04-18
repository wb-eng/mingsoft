using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_1d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] day = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            for(int i= 0; i<12; i++)
            {
                Console.WriteLine("{0} yue you {1} tian",i , day[i]);
            }
            Console.ReadLine();
        }
    }
}
