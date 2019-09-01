using NUnit.Framework;
using System.IO;
using System.Collections.Generic;
using Harpocrates_Secrets;

namespace Harpocrates_Secrets.Tests
{
    [TestFixture]
    public class Tests
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
    }
}