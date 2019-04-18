using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    //工厂模型
    class Program
    {

        static void Main(string[] args)
        {
            Creator c1 = new PenSupplier();
            Creator c2 = new PencilSupplier();
            Creator c3 = new RulerSupplier();
            Client client = new Client();
            c1.getStationeryFromFactory().Print();
            c2.getStationeryFromFactory().Print();
            c3.getStationeryFromFactory().Print();
            client.UseStationery(c1.getStationeryFromFactory());
            client.UseStationery(c2.getStationeryFromFactory());
            client.UseStationery(c3.getStationeryFromFactory());
            Console.ReadKey();
        }
        public class Client
        {
            public void UseStationery(Stationery s)
            {
                //使用stationery
            }
        }
        //文具类
        public abstract class Stationery
        {
            public abstract void Print();
        }
        public class Pen : Stationery
        {
            public override void Print()
            {
                Console.WriteLine("this is a Pen");
            }
        }
        public class Pencill : Stationery
        {
            public override void Print()
            {
                Console.WriteLine("this is a Pencil");
            }
        }
        public class Ruler : Stationery
        {
            public override void Print()
            {
                Console.WriteLine("this is a ruler");
            }
        }
        /// <summary>
        /// 抽象工厂类
        /// </summary>
        public abstract class Creator
        {
            public abstract Stationery getStationeryFromFactory();
        }
        public class PenSupplier : Creator
        {
            public override Stationery getStationeryFromFactory()
            {
                return new Pen();
            }
        }
        public class PencilSupplier : Creator
        {
            public override Stationery getStationeryFromFactory()
            {
                return new Pencill();
            }
        }
        //新添加的类 不需要去修改工厂类（只是定义规则）
        public class RulerSupplier : Creator
        {
            public override Stationery getStationeryFromFactory()
            {
                return new Ruler();
            }
        }
    }
}
