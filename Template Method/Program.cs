using System;

namespace Template_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Entity me = (Entity) new Human();
            Entity wolf = (Entity) new Wolf();
            
            me.walk();
            wolf.walk();
            System.Console.WriteLine();
            me.cook();
            wolf.hunt();
            System.Console.WriteLine();
            me.eat();
            wolf.eat();
        }
    }
}
