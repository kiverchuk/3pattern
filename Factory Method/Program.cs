using System;

namespace factory_method
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer dev = new PanelDeveloper("ООО КирпичСтрой");
            Console.WriteLine(dev.Name);
            House house2 = dev.Create();

            dev = new WoodDeveloper("Частный застройщик");
            Console.WriteLine(dev.Name);
            House house = dev.Create();

            Console.ReadLine();
        }
    }
}
