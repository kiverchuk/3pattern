using System;

namespace adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            ITarget target = (ITarget)new Adapter();

            client.ClientMethod(target);
        }
    }
}
