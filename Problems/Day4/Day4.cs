using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace Problems.Day4
{
    public class Day4: Problem
    {
        
        private string inputData;
        private List<string> passports;


        public Day4(string filePath)
        {
            inputData = File.ReadAllText(filePath);
        }

        private void SeparatePassports()
        {
            passports = new List<string>(inputData.Split("\r\n\r\n"));
        }
        
        private string GetValueFromField(string field)
        {
            return field.Split(':')[1];
        }
        
        private int GetPassportCount()
        {
            int validCount = 0;
            passports.ForEach(passport =>
            {
                if (PassportHasAllFields(passport))
                {
                    validCount++;
                }
            });
            return validCount;
        }
        
        private int GetValidatedPassportCount()
        {
            // TODO
            return 1;
        }

        private bool PassportHasAllFields(string passport)
        {
            return passport.Contains("ecl:") && passport.Contains("byr:") && passport.Contains("iyr:") &&
                   passport.Contains("eyr:") && passport.Contains("hgt:") && passport.Contains("hcl:") &&
                   passport.Contains("pid:");
        }

        public string FinalAnswerPart1()
        {
            SeparatePassports();

            return GetPassportCount().ToString();
        }

        public string FinalAnswerPart2()
        {
            SeparatePassports();

            return GetValidatedPassportCount().ToString();
        }
    }
}