using System;
using System.Collections.Generic;
using System.Text;

namespace day07
{
    class CollectionTest
    {
        public static void Mainsd(string[] args)
        {
            // 将一个数组中的奇数放到一个集合中，再将偶数放到另一个集合中
            // 最终将两个集合合并为一个集合，奇数显示在左面，偶数显示在右面
            int[] nums = { 1, 2,3,4,8,96,4,52,7,3,712,5};
            List<int> listOdd = new List<int>();
            List<int> listEven = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    listEven.Add(nums[i]);
                }
                else
                {
                    listOdd.Add(nums[i]);
                }
               
            }
            listOdd.AddRange(listEven);
            foreach (var item in listOdd)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            // 通过for-each循环，将用户输入的字符串赋值给一个字符数组
            Console.WriteLine("please input a string: ");
            string input = Console.ReadLine();
            // string可以看做为一个char类型的只读数组
            char[] chs = new char[input.Length];
            int j = 0;
            foreach (var item in input)
            {
                chs[j] = item;
                j++;
            }
            foreach (var item in chs)
            {
                Console.WriteLine(item);
            }


            // 统计welcome to china中每个字符出现的个数
            string str2 = "welcome to China";
           
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < str2.Length; i++)
            {
                if (str2[i] == ' ' )
                {
                    continue;
                }
                if (dic.ContainsKey(str2[i]))
                {
                    dic[str2[i]]++;
                }
                else 
                {
                    dic[str2[i]] = 1;
                }
            }

            foreach (KeyValuePair<char, int> item in dic)
            {
                Console.WriteLine("{0} appears {1} times", item.Key, item.Value);
            }
             
        }
    }
}
