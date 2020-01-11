using System;
using System.Collections.Generic;
using System.Text;

namespace day04
{
    class Constructor
    {
        /*构造函数：
         作用：帮助我们初始化对象，为一个特殊的方法
         1. 构造函数没有返回值，连void也没有。
         2. 构造函数的名称必须跟类名一样。
         */
        // 创建对象的时候会创建进入constructor
        private string _name;
        private int _age;
        private int _grade;

        // 析构函数，当程序结束的时候，程序才会执行
        // 帮助我们释放资源
        // GC Garbage Collection
        ~Constructor()
        { 
            
        
        }
        public Constructor(String name, int age, int grade) 
        {
            this.Name = name;
            this.Age = age;
            this.Grade = grade;

        }

        // Overloading

        public Constructor(String name) : this(name, 0, 0) { }
        
            // keywords: 1.代表当前类的对象； 2.在类当中显示的调用本类的构造函数 :this
            // this.Name = name;
        

    

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        
        }

        public int Grade
        {
            get { return _grade; }
            set { _grade = value; }
        }
    }
}
