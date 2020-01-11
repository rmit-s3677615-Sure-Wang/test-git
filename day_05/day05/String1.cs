using System;
using System.Diagnostics;
using System.Text;

namespace day05
{
    class String1
    {
        static void Mainsd(string[] args)
        {
            /* 字符串的不可变性
            1.当重新给一个string赋值是，老值并没有被销毁，而是重新开辟一块空间存储新的值
            当程序结束时，GC扫描整个内存，如果发现有的空间没有被指向，则立即销毁
            2.可以将string看做char的一个只读数组*/




            /*1. .Length
             * 2.ToUpper();
             * 3. ToLower();
        
             
             */
            string s = "2012-08-11";
            char[] ccc = { '-' };
            string[] date = s.Split(new char[] {'-'}, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("{0} year {1} month {2} day", date[0], date[1], date[2]);


            string name = "shuo";
            string names = "Shuo";
            string spliting = "a b c +=dfz,,";

            char[] chars = { ' ', ',', '+', '=' };
            string [] newString = spliting.Split(chars,StringSplitOptions.RemoveEmptyEntries);
            
            Console.WriteLine(newString.ToString());
            

            char [] chs = name.ToCharArray();
            //Console.WriteLine(chs.ToString());
            chs[0] = 'b';
           // name = new String(chs);
            Console.WriteLine(name);
            //Console.ReadKey();

            if (name.Equals(names, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("same");
            }
            else {
                Console.WriteLine("different");
            }

            StringBuilder sb = new StringBuilder();

            string str = null;
            // 计时方法

            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (int i = 0; i < 100000; i++)
            {
                
                str += i;
                //sb.Append(i);
            }

            sw.Stop();
            Console.WriteLine(sb.ToString());
            Console.WriteLine(sw.Elapsed);
            Console.ReadKey();

            
        }
    }
}
