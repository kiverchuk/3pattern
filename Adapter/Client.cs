using System;

namespace adapter
{
    internal class Client
    {
        public void ClientMethod(ITarget target)
        {
            target.Request();
            System.Console.WriteLine("Client work with adapted data");
        }
    }
}