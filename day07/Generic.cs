using System;
using System.Collections.Generic;
using System.Text;

namespace day07
{
    class Generic
    {
        public static void kkMain(string[] args)
        {
            List<int> list = new List<int>();
            // 数组类型可以直接反向转回arraylist
            int[] nums = list.ToArray();

            char[] chs = new char[] { 'a', 'b', 'c' };
            // 装箱和拆箱
            // 装箱：将值类型转换为引用类型
            // 拆箱：将引用类型转换为值类型
            // 装箱，拆箱需要消耗更多性能空间
            int n = 11;
            object o = n;//boxing
            int nn = (int)o; // unboxing

            // 看两种类型是否发生了装箱或者拆箱，要看，这两种类型是否存在继承关系
            // 装箱
            IComparable i = n;

            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "shuo wang");
            // edit
            dic[1] = "jin";
            foreach (var item in dic.Keys)
            {
                Console.WriteLine("{0}---{1}",item, dic[item]);
            }

            foreach (KeyValuePair<int, string> item in dic)
            {
                Console.WriteLine("{0}---{1}",item.Key,item.Value);
            }

        }
    }
}
