using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("面包店正在打折，活动进行中.......\n");
            Console.WriteLine("请输入星期：");
            string strWeek = Console.ReadLine();
            Console.WriteLine("请输入时间：");
            int intTime = Convert.ToInt32(Console.ReadLine());

            if ((strWeek=="星期二" && (intTime >=19 && intTime <=20)) || (strWeek =="星期六" && (intTime >=17 && intTime <=18)))
                {
                Console.WriteLine("恭喜获得折扣活动，尽快参与");
            }else
            {
                Console.WriteLine("对不起，来晚一步，期待下次活动...");
            }
            Console.ReadLine();
        }
    }
}
