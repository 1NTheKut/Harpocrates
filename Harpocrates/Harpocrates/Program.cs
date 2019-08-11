using System;
using System.Threading;
using MatthiWare.CommandLine;
using Harpocrates.CommandLineArg;
namespace Harpocrates
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //IntroductionLine();

            var options = new CommandLineParserOptions
            {
                AppName = "HARPOCRATES"
            };
            var parser = new CommandLineParser<CLIArgs>(options);
            var result = parser.Parse(args);
            if (result.HasErrors)
            {
                Console.Error.WriteLine("Error in command line arguments");
                System.Environment.Exit(1);
            }
        }

        //FunctionName: IntroducitonLine
        //Funcation Parameters->ReturnType: Void -> Void
        //Function Purpose: To introduce the purpose of the program in a slighly more dynamic way
        static void IntroductionLine()
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
