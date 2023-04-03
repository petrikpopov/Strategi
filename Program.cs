using System;

namespace Strateg_03._04._2023
{
    class Program
    {
        public class Context
        {
            public Strateg strateg { set; get; }

            public Context() { }
            public Context(Strateg s)
            {
                strateg = s;
            }
            public void SetStrat(Strateg obj)
            {
                strateg = obj;
            }
            public void Vibor()
            {
                Console.WriteLine("Введите сумму за которую вы хотите добраться к месту назначения in $");
                int A = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите время за которое вы хотите добраться к месту назначения in MIN");
                int B = Convert.ToInt32(Console.ReadLine());

                if (A>15||B>20)//car
                {
                    strateg.Transport();
                }
                if (A<5||B>35)//bus
                {
                    strateg.Transport();
                }
                if (A==0||B>60)//Bike
                {
                    strateg.Transport();
                }
            }
        }
        public abstract class Strateg
        {
            public int Money { set; get; }
            public int Time { set; get; }

            public Strateg() { }
            public Strateg(int M, int T)
            {
                Money = M;
                Time = T;
            }
            public abstract void Transport();
        }
        public class Car:Strateg
        {
            public override void Transport()
            {
                Console.WriteLine("Вы выброли поездку на машине");
            }
        }
        public class PublicBus : Strateg
        {
            public override void Transport()
            {
                Console.WriteLine("Вы выброли поездку на автобусе");
            }
        }
        public class Bike : Strateg
        {
            public override void Transport()
            {
                Console.WriteLine("Вы выброли поездку на велосипеде");
            }
        }
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Context context = new Context();
            context.SetStrat(new Bike());
            context.Vibor();
            context.SetStrat(new PublicBus());
            context.Vibor();
            context.SetStrat(new Car());
            context.Vibor();
        }
    }
}
