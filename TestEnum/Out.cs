using System;
using System.Collections.Generic;
using System.Text;

namespace FurtherMethod
{
    class Out
    {
        public static void sfsMain(string[] args) 
        {
            // out参数，如果在一个方法中，返回多个相同类型的值得时候，可以考虑返回一个数组
            // 不同类型的时候，out方法可以在一个方法返回不同类型的值
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int max, min, sum,avg;
            string s; 
            
            Test(numbers, out max, out min, out sum, out avg, out s);

        }
        /// <summary>
        /// 计算一个整数数组的最大值，最小值，平均值，求和
        /// </summary>
        /// <param name="nums">输入数组</param>
        /// <param name="max">多余 返回的最大值</param>
        /// <param name="min">多余 返回的最小值</param>
        /// <param name="sum">总和</param>
        /// <param name="avg">平均值</param>
        public static void Test(int[] nums, out int max, out int min, out int sum, out int avg, out string s)
        {
            max = nums[0];
            min = nums[0];
            sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i]>max) {
                    max = nums[i];
                }

                if (nums[i] < min)
                {
                    min = nums[i];                
                }
                sum += nums[i];
            }
            avg = sum / nums.Length;

            s = "shuo";

        }
    }
}
