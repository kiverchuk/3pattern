namespace adapter
{
    internal class Adapter : Server, ITarget
    {
        public void Request()
        {
            SpecificRequest();
            System.Console.WriteLine("Adapter adapt result for client");
        }
    }
}