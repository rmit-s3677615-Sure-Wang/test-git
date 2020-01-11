using System;
using System.Collections.Generic;
using System.Text;

namespace day08
{
    class Interface
    {
        public static void Mainsd(string[] args)
        {
            // 接口就是一个规范，能力。只要一个类继承了一个接口，就必须实现这个接口的所有方法
            // 接口无法实例化
            // 接口的identifier无法改变，默认为public
            // 接口中的成员不能有任何实现
            // 接口中只能有方法，属性，索引器，事件 不能有字段（field）和构造函数
            // interface可以多继承，只能interface继承interface（类既可以继承interface，又可以继承class）
            // 实现接口的子类必须实现该接口的全部成员
            // 继承类的位置永远比一个接口靠前

            // 现在都是面向interface编程，当实现了一个interface，就可以获取相应功能

            IFlyable fly = new Bird();
            // the method of interface
            fly.Fly();

            // the method of bird instance
            Bird bird = new Bird();
            bird.Fly();

        
        }
    }

    public class Person
    {
        public void SayHello() 
        {
            Console.WriteLine("i am a human");
        }
    
    }

    public class NBAPalyer : Person
    {
        public void KouLan()
        {
            Console.WriteLine("i can play basketball games");
        }
    
    }

    public class Student : Person
    {
        public void Koulan()
        {
            Console.WriteLine("baby play basketball games");
        }
    }

    public interface IKouLanable
    {
        // 接口中可以有方法和属性；理论上只能有方法

        // 接口中的成员不允许添加访问修饰符，默认就是public
        // 类中的修饰符，默认是private
        void Koulan();
        string Test();

        // 自动属性，不包括具体方法在内部
       int Age
        {
            get;
            set;
        }
    }






    public class Bird:IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("bird can fly");
        }

        // the solution for same name in the method
        //显示接口方法
        void IFlyable.Fly()
        {
            Console.WriteLine("i am the fly of interface");
        }
    }

    public interface IFlyable
    {
        void Fly();
    }
}
