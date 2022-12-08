using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TranzactAutomation.Drivers;
using TranzactAutomation.Pages;

namespace TranzactAutomation.Steps
{
    [Binding]
    public class RegisterSteps
    {
        private RegisterPage registerpage;

        [When(@"User creates an account and logs in")]
        public void AndUserCreatesAnAccountAndLogsIn()
        {
            string name = GenerateName(4) + " " + GenerateName(6);
            string email = name.Replace(' ', '_').ToUpper() + "@GMAIL.COM";
            string password = GenerateName(6);

            registerpage = new RegisterPage();
            registerpage.CreateAccount(name, email, password);
        }

        public static string GenerateName(int len)
        {
            Random r = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
            string Name = "";
            Name += consonants[r.Next(consonants.Length)].ToUpper();
            Name += vowels[r.Next(vowels.Length)];
            int b = 2; //b tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.
            while (b < len)
            {
                Name += consonants[r.Next(consonants.Length)];
                b++;
                Name += vowels[r.Next(vowels.Length)];
                b++;
            }
            return Name;
        }
    }
}
