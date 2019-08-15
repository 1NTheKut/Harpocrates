﻿using System;
using MatthiWare.CommandLine.Core.Attributes;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using MatthiWare.CommandLine;



namespace Harpocrates_Secrets.CommandLineArg
{
    public class CLIArgs
    {
        [Name("f", "first_name"), Description("First name of target")]
        public string FirstName { get; set; }
        [Name("l", "last_name"), Description("Last name of target")]
        public string LastName { get; set; }
        [Name("b", "birth_date"), Description("Birthday of target")]
        public string Birthday { get; set; }
        [Name("u", "username"), Description("Input a known username of the target")]
        public string Username { get; set; }
        [Name("l", "location"), Description("Where the target is from")]
        public string Location { get; set; }
        [Name("c", "company"), Description("Target's job")]
        public string Company { get; set; }
        [Name("p", "profile"), Description("If you have previously done some recon, you may attach an excel or json formatted document")]
        public string JSONProfile { get; set; }
        [Name("v", "verbose"), Description("Verbose Output"), DefaultValue(true)]
        public bool Verbose { get; set; }

       //Function name: ProcessCommandLineArguments
       //Function parameters => Return type: String[] => Void
       //Function Purpose: To handle passed in command line arguments
        public static void ProcessComandLineArguments(string[] args)
        {
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
            if (result.Result.JSONProfile != null && args.Length > 1)
            {
                Console.Error.WriteLine("Too many arguments. If you are uploading a file. Only use -p command.");
                System.Environment.Exit(2);
            }


        }

        //Function Name: ParseJson
        //Function Parameters => Return Type = String => Void
        //Function Purpose: To read in and save the user information JSON object in a dictionary
        public static void ParseJson(dynamic json)
        {
            using (StreamReader jsonReader = new StreamReader(json))
            {
                var readInJson = jsonReader.ReadToEnd();
                var items = JsonConvert.DeserializeObject<Dictionary<String, String>>(readInJson);
                foreach (var keys in items.Keys)
                {
                    Console.WriteLine("Parsed values from provided profile:");
                    Console.WriteLine("\t" + keys + ":" + items[keys]);
                }

            }

        }
    }


}
