using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_02
{
    public enum Gender
    { 
        male,
        female
    }

    // struct 可以帮我们一次性声明多个不同类型的变量
    // public struct name{ 成员(instance vaiable?)}
    public struct Person 
    {
        // 字段取名的区别
        
        public int _age;
        public Gender _gender;
        public string _name;
            }
    class Class1
    {
        public static void mainZ(string[] args) {


            // 变量
            Person zsPerson;
            zsPerson._age = 27;
            zsPerson._name = "shuo";
            zsPerson._gender = Gender.male;
        
            // 变量在程序运行期间只能存储一个值，而字段可以存储多个值

             
        }
         

    }
}
