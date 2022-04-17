using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_case2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入成绩");
            int grade  = Convert.ToInt32(Console.ReadLine());
            if (grade >=90)
            {
                Console.WriteLine("优秀");
            }else if(grade >= 80)
            {
                Console.WriteLine("中等");
            }else if(grade >=60)
            {
                Console.WriteLine("及格");
            }else
            {
                Console.WriteLine("不及格");
            }
            Console.ReadLine();
        }
    }
}
