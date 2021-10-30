namespace Template_Method
{
    internal class Wolf : Entity
    {
        public override void eat()
        {
            System.Console.WriteLine("Волк кушает добычу");
        }
        public override void hunt()
        {
            System.Console.WriteLine("Волк ловит добычу");

        }

    }
}