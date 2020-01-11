using System;

namespace day_01
{
    class Program
    {
        static void MainZ(string[] args)
        {
            #region
            Console.WriteLine("Fuck the world");
            // pause the current program
          
            int n = 3;
            #endregion
            
            // double, 后面15~16位
            // decimal, 用来存放金钱，后面28位，精度更高
            decimal money = 5000m;
            String name = "pengpeng";

            // 两遍不是字符串的时候，是求和
            Console.WriteLine("Fuck u " + name);

            // 占位符
            int n1 = 1;
            int n2 = 2;
            int n3 = 3;
            Console.WriteLine("first{0}, second {1}, third {2}", n1, n2, n3);
            Console.WriteLine("what a \n nice \"day\"");
            // \t 神奇的tap键
            // \b == insert（back space） 在输入两端无法使用
            // \\ reflect \
            // in path, @"fdsfaef" 1.可取消\的转义字符的作用，单纯的表示为一个\
            //                     2.保留文本原格式输出
            double d = n2 * 1.0 / n3;
            Console.WriteLine("the value of d is {0:0.00}",d);
            String input = Console.ReadLine();
            Console.WriteLine("your name is {0}", input);
            Console.ReadKey();
        }
    }
}
