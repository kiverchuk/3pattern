namespace Template_Method
{
    internal abstract class Entity
    {

        public abstract void eat();
        public virtual void cook() { }
        public virtual void hunt() { }
        public virtual void walk()
        {
            System.Console.WriteLine("Оно ходит");
        }
    }
}