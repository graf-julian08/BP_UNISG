using System;

namespace InheritanceCars
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
        public new void WhatAreYou() { Console.WriteLine("eeh du, echt cool"); }
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

            ((Opel)car1).WhatAreYou(); // output = I'm a Opel
            ((GolfGTI)car2).WhatAreYou(); // I'm a GTI
            ((Manta)car1).WhatAreYou(); // ehh du, echt cool
            ((SportsCar)car1).WhatAreYou(); // I'm a Opel
            car2.WhatAreYou(); // I'm a Golf GTI
            car1.WhatAreYou(); // I'm a Opel
        }
    }
}