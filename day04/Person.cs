using System;
using System.Collections.Generic;
using System.Text;

namespace day04
{
    // struct跟class相似，但struct不具备 封装；继承；多态。
    public struct PersonTwo
    {
        public string _name;
        public int _age;
        public string _gender;

        public void s()
        {
            // this只带当前instance
            Console.WriteLine("my name is {0}, {1}, {2}", this._name, this._gender, this._age);
        }
    }


    public class Person
    {
        // 类中包括 字段(field)，属性和方法
        // 类是不占内存的，对象占内存
        // 属性的作用就是保护字段，对字段的赋值和取值进行限定
        // 字段在类中需要是私有的
        private string _name;
        // property
        // 最终赋值还是给字段了，属性只起到一个中间件的作用，并不存值，只起处理作用
        public string Name
        {
            // 当你输出属性的值得时候，会执行get方法
            get { return _name; }
            // 当你给属性赋值的时候，首先会执行set方法
            set { _name = value; }
        
        }



        private int _age;
        public int Age
        {
            get { return _age; }
            set {  
                if (value <0 || value>100)
                {
                    value = 0;
                }
                _age = value; }
        
        }



        private string _gender;
        public string Gender
        {
            get {
                if (_gender != "male" && _gender != "female")
                {
                    return _gender = "male";
                }

                return _gender; }
            set { _gender = value; }
        
        }

        public void Student()
        {
            // this只带当前instance
            Console.WriteLine("my name is {0}, {1}, {2}", this.Name, this.Gender, this.Age);

        }



    }
}
