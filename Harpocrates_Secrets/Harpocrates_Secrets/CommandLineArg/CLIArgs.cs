using System;
using MatthiWare.CommandLine.Core.Attributes;


namespace Harpocrates_Secrets.CommandLineArg
{
    public class CLIArgs
    {
        [Required, Name("first", "first_name"), Description("First name of target")]
        public string FirstName { get; set; }
        [Required, Name("last", "last_name"), Description("Last name of target")]
        public string LastName { get; set; }
        [Name("birth_date", "birth_date"), Description("Birthday of target")]
        public string Birthday { get; set; }
        [Name("uanme", "username"), Description("Input a known username of the target")]
        public string Username { get; set; }
        [Name("l", "location"), Description("Where the target is from")]
        public string Location { get; set; }
        [Name("c", "company"), Description("Target's job")]
        public string Company { get; set; }
        [Name("p", "profile"), Description("If you have previously done some recon, you may attach an excel or json formatted document")]
        public string JSONProfile { get; set; }
        [Name("v", "verbose"), Description("Verbose Output"), DefaultValue(true)]
        public bool Verbose { get; set; }

        //Function Name: HandleJSONAttachment
        //Function Parameters => Return Type = String => Void
        //Function Purpose: To read in and save the user information JSON object in a dictionary
        public static void HandleJSONAttachment(string attachment)
        {

        }
    }


}
