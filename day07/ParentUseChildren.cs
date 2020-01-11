using System;

namespace day07
{
    class ParentUseChildren
    {
        static void Mainsd(string[] args)
        {

            /*里式转换
             1. 子类可以赋值给父类:如果有一个地方需要一个父类作为参数，我们可以给一个子类代替
             2.如果父类中装的是子类的对象，那么可以讲这个父类强转为子类对象*/
            Student s = new Student();
            Person p = s;
            string.Join("|", new string[] { "1","2","3","4"});

            // => Person s = new Student()
            // casting

            // equal to java instanceof
            // is: 表示类型转换，如果能够转换成功，则返回一个true，否则返回一个false
            // as： 表示类型转换，如果能够转换则返回对应的对象，否则返回一个null
            Student t = p as Student;
            // 如果转换成功，则返回一个object，否则返回null
            t.StudentSayHello();

            if (p is Teacher)
            {
                Student ss = (Student)p;
                ss.StudentSayHello();

            }
            else 
            {
                Console.WriteLine("transfer faulse");
            }
           
       

            // Person p = new Person();
            // 子类对象可以调用父类中的成员，但是父类对象永远都只能调用自己的成员
        }
    }

    public class Person
    {
        public void PersonSayHello()
        {
            Console.WriteLine("I am ur father");
        }
    }

    public class Student:Person
    {
        public void StudentSayHello()
        {
            Console.WriteLine("I am a student");
        }
        
    }

    public class Teacher : Person
    {
        public void TeacherSayHello()
        {
            Console.WriteLine("i am a teacher");
        
        }
    
    }
}
