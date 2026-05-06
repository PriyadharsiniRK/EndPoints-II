using System;

namespace EndPointsII
{
    public class ConsoleMessenger : Interface
    {
        public string SendMessage(string message)
        {
            Console.WriteLine(message);
            return message;
        }
    }
}