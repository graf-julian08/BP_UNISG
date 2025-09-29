namespace Inheritance
{
    public interface SportsCar
    {
        void WhatAreYou();
    }

    public interface GermanCar
    {
        void WhatAreYou();
    }

    public abstract class Car
    {
        public virtual void WhatAreYou() { Console.WriteLine("I am a Car"); }
    }

    public abstract class Golf : GermanCar
    {
        public virtual void WhatAreYou() { Console.WriteLine("I am a Golf"); }
    }

    public class GolfGTI : Golf, SportsCar
    {
        public override void WhatAreYou() { Console.WriteLine("I am a Golf GTI"); }
    }
    public class Manta : Opel, SportsCar
    {
        public override void WhatAreYou() { Console.WriteLine("eeh du, echt cool"); }
    }

    public class Opel : Car, GermanCar
    {
        public override void WhatAreYou() { Console.WriteLine("I am a Opel"); }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Manta();
            Golf car2 = new GolfGTI();

            ((Opel)car1).WhatAreYou(); // output ?
            ((GolfGTI)car2).WhatAreYou();
            ((Manta)car1).WhatAreYou();
            ((SportsCar)car1).WhatAreYou();
            car2.WhatAreYou();
            car1.WhatAreYou();
        }
    }
}
