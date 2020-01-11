using System;
using System.Collections.Generic;
using System.Text;

namespace day07
{
    class PolymophysimTest
    {
        public static void Main(string[] args)
        {
            MobileStorage md = new MobileDisk();
            Computer cpu = new Computer();
            // 为了拿到父类，可以通过：属性拿，传参 或者 constructor拿
            cpu.Ms = md;
            cpu.CpuRead();
            cpu.CpuWrite();
            //cpu.CpuRead(md);
            //cpu.CpuWrite(md);
        }
    }

    public abstract class MobileStorage
    {
        public abstract void Read();
        public abstract void Write();
    }

    public class MobileDisk : MobileStorage
    {

        public override void Read()
        {
            Console.WriteLine("mobile driver is reading data");
        }

        public override void Write()
        {
            Console.WriteLine("mobile driver is writing data");
        }

    }

    public class Computer
    {
        private MobileStorage _ms;
        public MobileStorage Ms
        {
            get { return _ms; }
            set { _ms = value; }
        }
        // 尽管调用的是父类类型，会有类型转换，自动使用子类的object
        public void CpuRead()
        {
            Ms.Read();
        }

        public void CpuWrite()
        {
            Ms.Write();
        }
    }
}
