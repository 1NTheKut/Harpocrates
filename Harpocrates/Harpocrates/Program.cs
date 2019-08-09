using System;
using System.Threading;


namespace Harpocrates
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Because I am extra, I want the message to print letter by letter
            string introLine = "Hello, my name is Harpocrates, the gatekeeper of secrets. What secrets would you like to uncover?";
            for (int i = 0; i < introLine.Length; i++)
            {
                Console.Write(introLine[i]);
                Thread.Sleep(75);
            }
        }
    }
}
