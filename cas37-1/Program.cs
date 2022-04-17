using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入年龄：");
            int age = Int32.Parse(Console.ReadLine());
            string info = age > 40 ? "中年人" : "年轻人";
            Console.WriteLine(info);
            Console.ReadLine();
        }
    }
}
