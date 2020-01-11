using System;

namespace day04
{
    class Program
    {
        static void Main(string[] args)
        {
            /* new关键字的作用：
            1.在内存中开辟一块儿空间；
            2.在开辟的空间中创建对象；
            3.调用对象的构造函数进行初始化对象*/
            Person shuo = new Person();
            shuo.Name = "Tremendous Sure";
            shuo.Age = -5;
            shuo.Gender = "MALE";

            shuo.Student();

            Ticket t = new Ticket(90);
            t.ShowTicket();
            Console.ReadKey();
            
        }



    }
}
