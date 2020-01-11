using System;
// 在一个项目中引用另一个项目的类：
// 1.dependencies --> frameworks --> add reference --> select what u want
using System.Collections.Generic;
using System.IO;
using System.Text;


// value type：int，double，bool,char, decimal, struct, enum -->栈
// ref type: string，array and customize class --> 堆


namespace day05
{
    class String2
    {
        /// <summary>
        /// string.indexOf(): 判断某个字符串中在字符串中第一次出现的位置，如果没有返回-1
        /// string.LastIndexOf(): 判断某个字符串最后一次出现的位置
        /// 
        /// string.Contains; return bool
        /// string.Replace("a", "b");
        /// 
        /// string.Substring截取字符串
        /// str.StartWith();
        /// str.EndWith();
        /// 
        /// str.IndexOf('value');
        /// str.LastIndexOf('a');
        /// 去空格
        /// str.Trim();
        /// str.TrimStart();
        /// str.TrimEnd
        /// str.IsNullOrEmpty()
        /// </summary>
        /// <param name="args"></param>
        public static void Mains(string [] args ) {
            //String str = "very important huge guy, shuo!";
            //string path = @"c:\a\b\c\pengpeng.PNG";

            //string[] names = { "a", "b", "c", "d" };

            //if (str.Contains("shuo"))
            //{
            //    str = str.Replace("shuo", "super NB Shuo");
            //}

            //string newStr = str.Substring(1, 2);
            //int index = path.LastIndexOf("\\");
            //path = path.Substring(index + 1);

            //params表示这里可以输入一个，或多个值
            //string strNew = string.Join("|", names);
            //equal to string.Join("|", "a", "b", "c", "d");

            //Console.WriteLine(strNew);

            //Console.WriteLine(path);
            //Console.WriteLine(str);
            //Console.ReadKey();

           

            // 1. reverse an index
            string str = "abcdefg";
            char[] chs = str.ToCharArray();
            char temp;

            for (int i = 0; i < chs.Length/2; i++)
            {
                temp = chs[i];
                chs[i] = chs[chs.Length - 1 - i];
                chs[chs.Length - 1 - i] = temp;

            }
            str = new string(chs);
            Console.WriteLine(str);

            // 2. reverse an string array
            string newTemp;
            string str2 = "hello C shrap";
            string [] strNew = str2.Split(" ");
            for (int i = 0; i < strNew.Length/2; i++)
            {
                newTemp = strNew[i];
                strNew[i] = strNew[strNew.Length - i - 1];
                strNew[strNew.Length - i - 1] = newTemp;
            }
            // string.join将字符串按照指定的分割符连接
            str2 = string.Join(" ", strNew);
            Console.WriteLine(str2);

            //for (int i = 0; i < strNew.Length; i++)
            //{
            //    Console.WriteLine(strNew[i]);
            //}

            // 3. extract e-mail address
            string email = "869224943@qq.com";
            int index = email.IndexOf('@');
            string userName = email.Substring(0, index);
            string yuMing = email.Substring(index + 1);
            Console.WriteLine(userName);
            Console.WriteLine(yuMing);

            // 4. extract info from content
            string path = @"D:\Desktop\WDT\IOtest.txt";
            string [] contents = File.ReadAllLines(path, Encoding.Default);
            for (int i = 0; i < contents.Length; i++)
            {
                string[] strr = contents[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine(strr[0] + "|" + strr[1]);

            }


            // find all location for e
            string str3 = "abcdsfsdafeafaselfjafasewf";
            int index3 = str3.IndexOf('e');
            int count = 0;
            while (index3 != -1)
            {
                index = str.IndexOf('e', index + 1);
            }
            Console.WriteLine(count);

            for (int i = 0; i < str3.Length; i++)
            {
                if (str[i] == 'e')
                {
                    Console.WriteLine(i);
                }
            }

             
            Console.ReadKey();

        }
    }
}
