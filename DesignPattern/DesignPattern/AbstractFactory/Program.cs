using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //抽象工厂模式 提供一个创建产品的接口创建相关或者依赖的对象，而不具体明确指定具体类
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory af1 = new WuhanSupplier();
            Beef b1= af1.GetBeef();
            Fish f1 = af1.GetFish();
            b1.Print();
            f1.Print();
            AbstractFactory af2 = new ShenzhenSupplier();
            af2.GetBeef().Print();
            af2.GetFish().Print();
        }
        private abstract class Fish
        {
            public abstract void Print();
        }
        private abstract class Beef
        {
            public abstract void Print();
        }
        private class WuhanFish : Fish
        {
            public override void Print()
            {
                Console.WriteLine("fish from Wuhan");
            }
        }
        private class ShenzhenFish : Fish
        {
            public override void Print()
            {
                Console.WriteLine("fish from Shenzhen");
            }
        }
        private class WuhanBeef:Beef
        {
            public override void Print()
            {
                Console.WriteLine("beef from Wuhan");
            }
        }
        private class ShenzhenBeef : Beef
        {
            public override void Print()
            {
                Console.WriteLine("beef from Shenzhen");
            }
        }
        private abstract class AbstractFactory
        {
            public abstract Fish GetFish();
            public abstract Beef GetBeef();
        }
        private class WuhanSupplier : AbstractFactory
        {
            public override Beef GetBeef()
            {
                return new WuhanBeef();
            }

            public override Fish GetFish()
            {
                return new WuhanFish();
            }
        }
        private class ShenzhenSupplier : AbstractFactory
        {
            public override Beef GetBeef()
            {
                return new ShenzhenBeef();
            }

            public override Fish GetFish()
            {
                return new ShenzhenFish();
            }
        }
    }
}
