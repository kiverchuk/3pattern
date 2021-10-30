namespace Template_Method
{
    internal class Human : Entity
    {
        public override void eat()
        {
            System.Console.WriteLine("Человек кушает на кухне");
        }
        public override void cook()
        {
            System.Console.WriteLine("Человек готовит на кухне");
        }

    }
}