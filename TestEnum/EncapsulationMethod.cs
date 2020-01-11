using System;
using System.Collections.Generic;
using System.Text;

namespace TestEnum
{
    class EncapsulationMethod
    {
        public static void dfdsMain(string[] args)
        {
            NewMethod();
        }
        // 方法的功能要单一；方法中最忌讳提示用户输入的信息；
        private static void NewMethod()
        {
            while (true)
            {
                try
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    break;

                }
                catch
                {
                    Console.WriteLine("wrong input");

                }
            }
            Console.WriteLine("wrong!");
        }

        public static void GetMax() { 
        
        }
    }
}
