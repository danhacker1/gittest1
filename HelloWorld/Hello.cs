using System;

namespace HelloWorld
{
    public class Hello : IHello
    {
        public Hello()
        {
            throw new Exception("Exception Message!!"); 
        }
        public string SayHello()
        {
            return "Hello from class!";
        }
    }
}