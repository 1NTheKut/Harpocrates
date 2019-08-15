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
using Newtonsoft.Json;

namespace Harpocrates_Secrets
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Helllo World");
            //CreateWebHostBuilder(args).Build().Run();
            //IntroductionLine();
            CLIArgs.ProcessComandLineArguments(args);
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
            string introLine = "Hello, my name is Harpocrates, the gatekeeper of secrets. Let's see what you've you got";
            for (int i = 0; i < introLine.Length; i++)
            {
                Console.Write(introLine[i]);
                Thread.Sleep(75);
            }

            Console.WriteLine("Constructing profile from provided information");
        }

    }


}


