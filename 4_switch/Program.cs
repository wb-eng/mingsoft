using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入等级");
            char grade = char.Parse(Console.ReadLine());
            
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("最好");
                    break;
                case 'B':
                    Console.WriteLine("第二好");
                    break ;
                case 'C':
                    Console.WriteLine("不太行");
                    break;
                default:
                    Console.WriteLine("请输入正确的等级");
                    break;
            }
            Console.ReadLine();
        }
    }
}
