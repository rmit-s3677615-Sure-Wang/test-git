using System;
using System.Collections.Generic;
using System.Text;

namespace day05
{
    class inheritance
    {

        public static void Main(String[] args)
        {
            Student shuo = new Student("shuo", 27, "male", 3677615);
            Person pengpeng = new Student("pengpeng", 28, "male", 2323);
            pengpeng.SayHello();
            shuo.SayHello();
        
        }
    }
    // 父类的private关键字，子类不能继承
    // 继承的单根型：一个子类只能有一个父类
    // 继承的传递性：子类能继承爷爷的
    // 子类未继承父类的构造函数，但子类会默认调用父类无参数的构造函数， which创建父类对象，让子类可以使用父类中的成员
    // 所以如果在父类中重新写了一个有参数的构造函数之后，那个无参的constructor就被干掉了，子类就调用不到了
    // 解法：1。在父类中重新写一个无参数的constructor；2.在子类中调用父类的构造函数:base

    public class Person
    {
        private string _name;
        private int _age;
        private string _gender;

        public Person(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public void SayHello()
        {
            Console.WriteLine("i am a human being");
        }

    }

    // 子类的构造函数需完全继承父类的所有方法
    public class Student:Person
        
    {
        private int _id;
        public Student(string name, int age, string gender, int id) : base(name,age,gender)
        {
            this.Id = id;
        
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }        
        }

        // 如果子类有父类的相同名称的方法， 确定隐藏父类的方法
        // 需要用关键字 new
        public new void SayHello()
        {
            Console.WriteLine("I am a student");
        
        }

    }

    public class Teacher : Person
    {
        private double _salary;

        public Teacher(string name, int age, string gender, double salary):base(name, age, gender)
        {
            this.Salary = salary;
        
        }

        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public new void SayHello()
        {
            Console.WriteLine("I am a teacher");
        }
    
    }
}
