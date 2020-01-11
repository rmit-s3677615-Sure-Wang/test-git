using System;

namespace TestEnum
{
    class mehtod
    {
        // 字段，属于类的字段（类似于全局变量）
        public static int _number = 10;
        static void ZfMain(string[] args)
        {
             
            Console.WriteLine(GetMax(1,3));
         
        }

        /// <summary>
        /// calculate the max value and then return the values
        /// </summary>
        /// <param name="n1">1</param>
        /// <param name="n2">2</param>
        /// <returns>the max one</returns>
        public static int GetMax(int n1, int n2) 
        {
            return n1>n2? n1:n2;
        }
    }
}
