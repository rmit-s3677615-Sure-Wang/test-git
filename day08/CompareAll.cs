using System;
using System.Collections.Generic;
using System.Text;

namespace day08
{
    class CompareAll
    {
        static void Main(string[] args)
        {
            // virtual,abstract and interface?
            // virtual: 能抽象出一个父类，抽象出的父类可以写，并且我还需要创建相关的对象

            // abstract: 能抽象出一个父类，并且能够写出子类所需要的共有的方法，并且你不知道如何写这个方法

            // interface: 无法抽象出父类，但是能分离出相似的功能； eg. 鸟和直升机都会飞
            ISwimming swim1 = new ReadDuck();
            ISwimming swim2 = new QPDuck();
            ISwimming swim3 = new WoodDuck();
            swim1.Swim();
            swim2.Swim();
            swim3.Swim();
        }
    }

    public interface ISwimming
    {
        void Swim();
    }

    public class ReadDuck : ISwimming
    {
        public void Swim()
        {
            Console.WriteLine("i can swim");
        }
    }

    public class QPDuck : ISwimming
    {
        public void Swim()
        {
            Console.WriteLine("i can float on the water");
        }
    }

    public class WoodDuck : ISwimming
    {

        void ISwimming.Swim()
        {
            Console.WriteLine("i cannot in the water");
        }
    }
}
