using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = 1.68;
            int weight = 78;
            double exponent = weight/(height*height);
            Console.WriteLine("您的身高为：" + height);
            Console.WriteLine("您的体重为：" + weight);
            Console.WriteLine("您的BMI为："+ exponent);
            Console.WriteLine("您的体重属于");
            if(exponent <18.5 )
            {
                Console.WriteLine("体重过轻");
            }
            else if(exponent >= 18.5 && exponent < 24.9)
            {
                Console.WriteLine("正常范围");
            }else if(exponent >= 24.9 && exponent < 29.9)
            {
                Console.WriteLine("体重过重");
            }else if(exponent >= 29.9)
            {
                Console.WriteLine("肥胖");
            }
            Console.ReadLine();
       }
    }
}
