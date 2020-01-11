using System;
using System.Collections.Generic;
using System.Text;

namespace FurtherMethod
{
    class Ref
    {
        // ref参数：能够将一个变量带入一个方法中进行改变，改变完成后，再将改变后的值带出方法
        // ref参数要求在AI方法外必须为其赋值，而方法内可以不赋值
        // ps: 与out方法刚好相反
        public static void aaMain(string[] args) {
            double salary = 5000;
            // 发送的为变量值的拷贝
            Ref.Minus(salary);
            Console.WriteLine(salary);

            // 发送的为变量地址的引用
            Ref.Reward(ref salary);
            Console.WriteLine(salary);
            Console.ReadKey();

        }

        public static void Reward(ref double s)
        {
            s += 500;
        }

        public static void Minus(double s)
        {
            s -= 500;
        }
    }
}
