using System;
using System.Collections.Generic;
using System.Text;

namespace FurtherMethod
{
    class Paras
    {
        public static void Main(string [] args) 
        {
            Test("san", 99, 88, 77);
            int[] s = { 99, 88, 77 };
            Test("s",3,s);
            Console.ReadKey(); 
        }

        // params可变参数
        // 将实参列表中 跟 可变参数数组类型 一致的元素都当做数组的元素去处理
        // 且必须是最后一个元素, 且具有唯一性。
        public static void Test(string name, int id, params int[] score)
        {
            int sum = 0;
            for (int i = 0; i < score.Length; i++)
            {
                sum += score[i];
            }
            Console.WriteLine("{0} with id got the grade is {1}", name, id, sum);
        
        }
    }
}
