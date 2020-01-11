using System;

namespace day08
{
    class Identifier
    {
        //屏蔽了所有子类差异，返回子类对象
        // 工厂方法
        public static NoteBook GetNoteBook(string brand)
        {
            NoteBook nb = null;
            switch (brand)
            {
                case "Lenovo": nb = new Lenovo();
                    break;
                case "Acer": nb = new Acer();
                    break;
            }


            return nb;
        }
        static void Mainss(string[] args)
        {
            /*
             能够修饰class的访问修饰符只有两个，一个是public，一个是internal（default）：在当前项目中访问
             internal：只能在当前项目中访问；在同一个项目中，internal和public的权限一样
             protect：该类及其子类中
             ps:同一个项目中，internal的权限要大于protected，但protected可以跨项目
             protected internal: &

            子类的访问权限不能高于父类
             */

            // 设计模式：设计这个项目的一种方式；一共23中设计模式解决23中设计问题
            // factory
            Console.WriteLine("please input the brand which u want");
            string brand = Console.ReadLine();
            NoteBook nb = Identifier.GetNoteBook(brand);
            nb.SayHello();
            Console.ReadKey();

        }




    }

    public abstract class NoteBook
    {
        public abstract void SayHello();
    }

    public class Lenovo : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("i am a Lenovo");
        }
    
    }

    public class Acer : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("i am a Acer");
        }
    }
}
