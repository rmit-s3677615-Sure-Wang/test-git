using System;
using System.Collections.Generic;
using System.Text;

namespace FurtherMethod
{
    class out2
    {
        public static void sdMain(String[] args)
        {
            int num;
            bool b = out2.MyTryParse("123abc", out num);
            Console.WriteLine(b);
            Console.ReadKey();
        }

        public static bool MyTryParse(string s, out int result)
        {
            result = 0;
            try
            {
                result = Convert.ToInt32(s);
                return true;
            }
            catch
            {
                return false;
            }
        
        }
    }
}
