using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace day07
{
    class Path1
    {
        public static void Mainsss(string[] args)
        {
            string str = @"D:\Desktop\WDT\IOtest.txt";
            // path.getfile name, 快速获得路径下的文件名称
            Console.WriteLine(Path.GetFileName(str));
            File.Create(@"D:\Desktop\WDT\new.txt");

            // delete a file
            // File.Delete(@"D:\Desktop\WDT\new.txt");

            // 读入文件in 数组形式
            string[] contents = File.ReadAllLines(@"D:\Desktop\WDT\IOtest.txt", Encoding.Default);
            foreach (var item in contents)
            {
                Console.WriteLine(item);
            }

            // 读入文件为string形式
            string newStr = File.ReadAllText(@"D:\Desktop\WDT\IOtest.txt", Encoding.Default);
            Console.WriteLine(newStr);

            // 将视频文件转换成字节码
            //byte[] buffer = File.ReadAllBytes(@"D:\Desktop\1.avi");
            //string s = Encoding.Default.GetString(buffer);
            //Console.WriteLine(s);

            // 将string转换成数组
            string str2 = "what a nice day! lets go jogging!";
            byte[] buffer2 = Encoding.Default.GetBytes(str);
            //string ss = Encoding.Default.GetString(buffer2);
            foreach (var item in buffer2)
            {
                Console.WriteLine(item);
            }

            //File.WriteAllBytes(@"D:\Desktop\WDT\new.txt", buffer2);

            // 绝对路径：从根路径找到目标（recommended）
            // 相对路径：文件相对于应用程序的路径
            File.WriteAllLines(@"D:\Desktop\WDT\NEWtest.txt", new string[] { "Zoe", "Jin" });
            Console.WriteLine("OK");

            // 但是只适合读取小文件，大文件需要用文件流读取
            Console.ReadKey();


        }
    }
}
