using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c = 89, csharpe = 90, sql = 60;
            int sub = csharpe - sql;
            double avg = (c + csharpe + sql) / 3;
            Console.WriteLine("C#课和SQL课的分数之差"+ sub + "分");
            Console.WriteLine("3门课的平均分" + avg + "分");
            Console.ReadLine();
        }
    }
}
