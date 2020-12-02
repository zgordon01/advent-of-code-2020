using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems.Day2
{
    public class PasswordValidator
    {
        private List<Password> passwords = new List<Password>();

        public PasswordValidator(List<string> passwordAndPolicyStrings)
        {
            foreach (var passwordAndPolicy in passwordAndPolicyStrings)
            {
                this.passwords.Add(this.GeneratePasswordFromCombinedString(passwordAndPolicy));
            }
        }

        private Password GeneratePasswordFromCombinedString(string passwordAndPolicyString)
        {
            string[] policyAndPassword = passwordAndPolicyString.Split(" ");
            int policyMin;
            int policyMax;
            char policyChar;
            string body;

            try
            {
                policyMin = Int32.Parse(policyAndPassword[0].Split("-")[0]);
                policyMax = Int32.Parse(policyAndPassword[0].Split("-")[1]);
                policyChar = policyAndPassword[1][0];
                body = policyAndPassword[2];
                
                return new Password
                {
                    body = body,
                    policyChar = policyChar,
                    policyMin = policyMin,
                    policyMax = policyMax
                };
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            return new Password
            {
                body = "",
                policyChar = char.MinValue,
                policyMin = 0,
                policyMax = 0
            };
        }

        private List<Password> GetValidPasswords()
        {
            List<Password> validPasswords = new List<Password>();
            foreach (var password in passwords)
            {
                IEnumerable<char> policyCharacters = password.body.Where(x => x.Equals(password.policyChar));
                int numberOfPolicyCharacters = policyCharacters.Count();
                if (numberOfPolicyCharacters >= password.policyMin && (numberOfPolicyCharacters <= password.policyMax))
                {
                    validPasswords.Add(password);
                }
            }

            return validPasswords;
        }
        
        private List<Password> GetValidPasswordsWithTobogganPolicy()
        {
            List<Password> validPasswords = new List<Password>();
            foreach (var password in passwords)
            {
                int minIndex = password.policyMin - 1;
                int maxIndex = password.policyMax - 1;
                minIndex = minIndex >= 0 ? minIndex : 0; 
                maxIndex = maxIndex >= 0 ? maxIndex : 0;

                bool minCharMatches = password.body[minIndex] == password.policyChar;
                bool maxCharMatches = password.body[maxIndex] == password.policyChar;

                bool bothMatch = minCharMatches && maxCharMatches;

                if ((minCharMatches || maxCharMatches) && !bothMatch)
                {
                    validPasswords.Add(password);
                }

            }

            return validPasswords;
        }

        public int GetFinalAnswerPart1()
        {
            Console.WriteLine("Day 2 Part 1 Final Answer:");
            List<Password> goodPasswords = this.GetValidPasswords();
            foreach (var password in goodPasswords)
            {
                Console.WriteLine($"Found good password {password.body}");
            }
            Console.WriteLine($"Total of {goodPasswords.Count} good passwords");
            return goodPasswords.Count;
        }
        
        public int GetFinalAnswerTobogganPolicy()
        {
            Console.WriteLine("Day 2 Part 2 Final Answer:");
            List<Password> goodPasswords = this.GetValidPasswordsWithTobogganPolicy();
            foreach (var password in goodPasswords)
            {
                Console.WriteLine($"Found good password {password.body}");
            }
            Console.WriteLine($"Total of {goodPasswords.Count} good passwords");
            return goodPasswords.Count;
        }

    }
}