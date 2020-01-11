using System;
using System.Collections.Generic;
using System.Text;

namespace day07
{
    class Abstract
    {
        public static void sdsMain(string[] args)
        {
            // 实现多态的方法：1.虚方法：将父类的方法标记为虚方法，用virtual关键字，这个类可以被子类重新写一遍 + override
            // 2. 抽象类：当父类中的方法不知道如何去实现时，可以考虑将父类写成抽象类，方法写成抽象方法
            
            
            // 抽象类和virtual的区别 抽象类：不可实例化； virtual类：可实例化，父类有意义
            
            /*
             抽象类的特点：
             1. 抽象成员必须标记为abstract，并且不能有任何实现
             2. 抽象成员必须在抽象类中
             3. 抽象类cannot be initialization
             4. 子类继承抽象类后，必须把父类中所有抽象成员都重写(除非子类也是一个抽象类)
             5. 抽象成员的访问修饰符不能使private  <--
             6. 抽象类中可以包含实例成员，并且抽象类的实例成员可以不被子类实现
             7. 抽象类是有构造函数的，虽然不能被实例化
             
            ps: 如果父类中的方法有默认的实现，并且父类需要被实例化，用virtual实现多态
            若父类中的方法没有默认实现，父类也不需要被实例化，则可以将该类定义为抽象类
             
             
             */
            Chinese cn = new Chinese("shuo");
            TaiWan tw = new TaiWan("jin");
            People[] pers = new People[2] { cn, tw };

            for (int i = 0; i < pers.Length; i++)
            {
                pers[i].SayHello();
            }

            // 抽象类和接口无法创建对象
            // Animal a = new Animal();
            Animal a = new Dog();
            a.Bark();

        }
    }


    public abstract class Animal
    {
        private int _age;
        // 抽象方法没有方法体
        public abstract void Bark();

        public int Age
        {
            get { return _age; }
            set { _age = value; }        
        }

        // 抽象类中可以有虚方法，虚方法在子类中不必须被重写
        // 虽然有意义，即子类可以去override它；但意义不大，普通类可以完全代替
        // 抽象类的意义在于提供抽象成员 which供子类去override；如果类里有抽象成员，写抽象类；如果没有抽象成员，不写抽象类
        public virtual void TestVirtual()
        { }

        // abstract property
        public abstract string Name
        {
            get;
            set;
        }

        // 如果父类的抽象方法中有参数，那么，继承这个抽象父类的的子类在重写父类的方法的时候，必须传入对应的参数
        // 如果抽象父类的抽象方法中有返回值，那么子类在重写这个抽象方法的时候，也必须要传入返回值。
        public abstract string TestString(string name);


    }

    public abstract class Test : Animal { }

    // alt + shift + f10
    public class Dog : Animal
    {
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public override void Bark()
        {
            Console.WriteLine("Margo wang wang wang!"); 
        }

        
        public override string TestString(string name)
        {
            throw new NotImplementedException();
        }
    }

    public class Cat : Animal 
    {
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Bark()
        {
            Console.WriteLine("Cat miao miao maio");
        }

        public override string TestString(string name)
        {
            throw new NotImplementedException();
        }
    }


    // polymophism
    public class People
    {
        private string _name;
        public string Name { get => _name; set => _name = value; }

        public People(string name)
        {
            this.Name = name;
        }

        public virtual void SayHello()
        {
            Console.WriteLine("I am a human being");
        }
    }
    public class Chinese : People
    {
        public Chinese(string name) : base(name)
        {
        }
        public override void SayHello()
        {
            Console.WriteLine("ni hao!");
        }
    }

    public class TaiWan : People
    {
        public TaiWan(string name) : base(name) { }
        public override void SayHello()
        {
            Console.WriteLine("wang wang wang!");
        }
    }



}
