using System;
using System.Collections.Generic;
using System.Text;

namespace day04
{
    class StaticAndNStatic
    {
        // 只要是静态成员，都需要类名去直接调用；无论是否在同一个类中
        // 即，静态成员必须使用类名去调用，而实例成员使用对象名调用
        // 静态函数中，只能访问静态成员，不允许访问实例成员
        // 实例方法中，既可以使用静态成员，也可使用实例成员

            //静态类中只允许使用静态成员，不允许出现实例成员 
        private static string _name;
        private string _gender;

       

        public static string Name
        {
            get { return StaticAndNStatic._name; }
            set { StaticAndNStatic._name = value; }        
        }

        // 快捷键 ctrl + r+e
        public string Gender { get => _gender; set => _gender = value; }
    }
}
