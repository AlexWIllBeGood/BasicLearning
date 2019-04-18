using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 非简单工厂模式的实现方式
            //Customer c = new Customer();
            //Food food1 = c.Cook("TomatoScrambleEgg");
            //Food food2 = c.Cook("PepperScrambleMeat");
            //Food food3 = c.Cook("KFC");
            //food1.Print();
            //food2.Print();
            //food3.Print();
            #endregion
            #region 简易工厂模式的实现方法
            Customer c = new Customer();
            Food food1 = FoodSimpleFactory.getFood("TomatoScrambleEgg");
            Food food2 = FoodSimpleFactory.getFood("PepperScrambleMeat");
            Food food3 = FoodSimpleFactory.getFood("KFC");
            c.GetFood(food1);
            c.GetFood(food2);
            c.GetFood(food3);
            food1.Print();
            food2.Print();
            food3.Print();
            #endregion
            Console.ReadKey();
        }

        #region 非简易工厂
        ////不是使用简单工厂的情况（自己炒菜去吃）
        //public class Customer
        //{
        //    public Food Cook(string typeOfDessert)
        //    {
        //        Food food;
        //        switch (typeOfDessert)
        //        {
        //            case "TomatoScrambleEgg":
        //                food = new TomatoScrambleEgg();
        //                break;
        //            case "PepperScrambleMeat":
        //                food= new PepperScrambleMeat();
        //                break;
        //            default:
        //                food = new GetFoodRare();
        //                break;
        //        }
        //        return food;
        //    }
        //}
        //class Teacher
        //{
        //    //假如有有一个教师类也也需要去做饭，需要重新写cook方法
        //}
        //public abstract class Food
        //{
        //    public abstract void Print();
        //}
        //public class TomatoScrambleEgg : Food
        //{
        //    public override void Print()
        //    {
        //        Console.WriteLine("this is a tasty tomato scramble egg!");
        //    }
        //}
        //public class PepperScrambleMeat : Food
        //{
        //    public override void Print()
        //    {
        //        Console.WriteLine("this is a tasty pepper scramble meat!");
        //    }
        //}
        //public class GetFoodRare : Food
        //{
        //    public override void Print()
        //    {
        //        Console.WriteLine("this is a tasty rare food!");
        //    }
        //}
        #endregion

        #region 简易工厂
        public abstract class Food
        {
            public abstract void Print();
        }
        public class TomatoScrambleEgg : Food
        {
            public override void Print()
            {
                Console.WriteLine("this is a tasty tomato scramble egg!");
            }
        }
        public class PepperScrambleMeat : Food
        {
            public override void Print()
            {
                Console.WriteLine("this is a tasty pepper scramble meat!");
            }
        }
        public class GetFoodRare : Food
        {
            public override void Print()
            {
                Console.WriteLine("this is a tasty rare food!");
            }
        }
        public class FoodSimpleFactory
        {
            //抽象工厂类简单来说就是去制造所需要的对象
            //所有“生产”相关代码写在这个工厂里面
            public static Food getFood(string type)
            {
                Food food = null;
                switch (type)
                {
                    case "TomatoScrambleEgg":
                        food = new TomatoScrambleEgg();
                        break;
                    case "PepperScrambleMeat":
                        food = new PepperScrambleMeat();
                        break;
                    default:
                        food = new GetFoodRare();
                        break;
                }
                return food;
            }
        }
        public class Customer
        {
            public void GetFood(Food food)
            { }
        }
        #endregion
    }
}