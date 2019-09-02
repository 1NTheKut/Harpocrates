using NUnit.Framework;
using System.IO;
using System.Collections.Generic;
using Harpocrates_Secrets;
using MatthiWare.CommandLine;


namespace Harpocrates_Secrets.Tests
{
    [TestFixture]
    public class CLI_Tests
    {
        [TestCase]
        public void ParseJSON_Test_IsNotNull()
        {
            string testFile = "/Users/roottoor/Desktop/Programming-Projects/FindYourExposure/Harpocrates/test.json";
            var parsedResult = CommandLineArg.CLIArgs.ParseJson(testFile);
            Assert.That(parsedResult, Is.Not.Null);
        }

        [TestCase]
        public void ParseJSON_Test_IsDictionary()
        {
            string testFile = "/Users/roottoor/Desktop/Programming-Projects/FindYourExposure/Harpocrates/test.json";
            var parsedResult = CommandLineArg.CLIArgs.ParseJson(testFile);
            Assert.That(parsedResult, Is.InstanceOf<Dictionary<string,string>>());

        }

        [TestCase]
        public void HandleJSON_Test_WhenJSONSubmitted()
        {
            bool submittedJSON = true;
            var testDictionary = new Dictionary<string, string>();
            var parser = new CommandLineParser<CommandLineArg.CLIArgs>();
            string testFile = "/Users/roottoor/Desktop/Programming-Projects/FindYourExposure/Harpocrates/test.json";
            var testArgs = new string[] { "p", testFile };
            var result = parser.Parse(testArgs);
            result.Result.JSONProfile = "/Users/roottoor/Desktop/Programming-Projects/FindYourExposure/Harpocrates/test.json";

            var rezResult = CommandLineArg.CLIArgs.HandleJSON(submittedJSON, result.Result, testDictionary);

            Assert.That(rezResult, Is.InstanceOf<Dictionary<string, string>>());
        }


        [TestCase]
        public void HandleJSONTest_WhenJSONNotSubmitted()
        {

        }

    }
}