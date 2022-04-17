using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_case1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个数字");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i % 2 != 0){
                Console.WriteLine("输入值为奇数");
            }
            else
            {
                Console.WriteLine("输入值为偶数");
            }
           Console.ReadLine();
        }
    }
}
