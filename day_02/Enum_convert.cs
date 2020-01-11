using System;
namespace day_02
{
    public enum QQstate 
    {
        OnLine,
        OffLine,
        Leave,
        Busy,
        QMe
    }
    class Enum_convert
    {
        static void MainZwe(string[] args)
        {
            string s = "123";
            int n1 = 3;
            int n2 = 4;
            int n3 = 5;

            int a = 5;
            int b = a++ + ++a * 2 + --a + a++;

            int max = n1 > n2 ? n1 : n2;
            Console.WriteLine(max);
            //       5+7*2+6+6 = b      a = 7    number++ 为一元运算符（优先级高于二元运算符）
            //                                   a = a + b 为二元运算符
            Console.WriteLine(a + " " + b);
            // (int)5 先将n3转换成int，*0.1再将int类型转成double
            double n4 = (int)n3*0.1 / n1;
            Console.WriteLine(n4);
            // 强转
            double d = Convert.ToDouble(s); 

            // try parse能够判断是否类型可转；
            //可转，赋值number为转换后的值，bool为true；不可转，number = 0， bool = false
            int number = 0;
            bool e = int.TryParse("123ab", out number);
            Console.WriteLine(number);
            Console.WriteLine(e);
            

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(d);
            Console.ReadKey();

            Console.WriteLine("please select the status of now! 1--OnLine 2--OffLine 3--Leave 4--Busy");
            String input = Console.ReadLine();
            switch (input) {
                case "1": QQstate s1 = (QQstate)Enum.Parse(typeof(QQstate), input);
                    Console.WriteLine("u selected the status is {0}", s1);
                    break;
                case "2": QQstate s2 = (QQstate)Enum.Parse(typeof(QQstate), input);
                    Console.WriteLine("u selected the status is {0}", s2);
                    break;
                case "3": QQstate s3 = (QQstate)Enum.Parse(typeof(QQstate), input);
                    Console.WriteLine("u selected the status is {0}", s3);
                    break;
                case "4": QQstate s4 = (QQstate)Enum.Parse(typeof(QQstate), input);
                    Console.WriteLine("u selected the status is {0}", s4);
                    break;
                                
            }

        }
    }
}
