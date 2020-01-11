using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace day07
{
    class Collections
    {
        public static void Mainds(string[] args)
        {
            // 1. arrayList
            // 我们将一个对象输出到console，默认情况下，拿到的是这个对象所在类的namespace
            ArrayList list = new ArrayList();
            list.Add(1);
            // add range can add an array in the array list
            list.AddRange(new int[] { 1, 2, 3, 4, 5, 6 });
            // list.Clear();
            list.Remove(1);
            list.RemoveAt(0);
            list.RemoveRange(1,2);
            list.Sort();
            list.Reverse();
            // 在指定位置插入元素
            list.Insert(2, "anme");
            // 出入一个数组
            list.InsertRange(0, new int[] { 1, 2 });
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine("=================");

            // 2. hashMap
            // 倒序输出
            Hashtable ht = new Hashtable();
            ht.Add(1, "shuyo");
            ht.Add(2, "pengpeng ");
            ht[3] = "new coming";

            
            //for (int i = 0; i < ht.Count; i++)
            //{
            //    Console.WriteLine(ht[i]);
            //}

            // C# 是一门强类型的语言：在代码中，必须对每一个变量的类型有一个明确的定义
            // js 是一门弱类型语言
            foreach (var item in ht.Keys)
            {
                Console.WriteLine(ht[item]);
            }

            Console.ReadKey();

        }
    }
}
