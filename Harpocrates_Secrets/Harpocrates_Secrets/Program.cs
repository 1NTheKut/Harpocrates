using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Threading;
using MatthiWare.CommandLine;
using Harpocrates_Secrets.CommandLineArg;

namespace Harpocrates_Secrets
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var parsedCommandLine = CLIArgs.ProcessComandLineArguments(args).Where(kvp => kvp.Value != null);
            Console.WriteLine("Below is the following information you have provided.\n\nNOTE: If some of the vaues you have " +
                "inputted are not shown below you may have included a non-existent parameter.");
            foreach (KeyValuePair<string, string> item in parsedCommandLine)
            {
                Console.WriteLine(item);
            }

        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

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
          
            Console.WriteLine("Constructing profile from provided information");
        }

    }


}