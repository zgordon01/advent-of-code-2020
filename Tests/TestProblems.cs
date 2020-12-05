using Problems.Day1;
using Problems.Day2;
using Problems.Day3;
using Problems.Day4;
using Problems.Day5;
using Xunit;

namespace Tests
{
    public class TestProblems
    {
        [Fact]
        public void SanityTest()
        {
            Assert.True(true);
        }
        [Fact]
        public void ExpenseReportDay1()
        {
            
            ExpenseReport expenseReport = new ExpenseReport(Problems.Day1.PuzzleInput.Expenses);
            int finalAnswer = expenseReport.GetFinalAnswerPart1();
            Assert.NotEqual(0, finalAnswer);
        }
        [Fact]
        public void ExpenseReportDay1Part2()
        {
            ExpenseReport expenseReport = new ExpenseReport(Problems.Day1.PuzzleInput.Expenses);
            int finalAnswer = expenseReport.GetFinalAnswerPart2();
            Assert.NotEqual(0, finalAnswer);
        }
        [Fact]
        public void PasswordsDay2Part1()
        {
            PasswordValidator passwordValidator = new PasswordValidator(Problems.Day2.PuzzleInput.Passwords);
            int numberOfValidPasswords = passwordValidator.GetFinalAnswerPart1();
            Assert.Equal(636, numberOfValidPasswords);
        }
        [Fact]
        public void PasswordsDay2Part2()
        {
            PasswordValidator passwordValidator = new PasswordValidator(Problems.Day2.PuzzleInput.Passwords);
            int numberOfValidPasswords = passwordValidator.GetFinalAnswerTobogganPolicy();
            Assert.Equal(588, numberOfValidPasswords);
        }
        [Fact]
        public void Day3Part1()
        {
            Day3 day3 = new Day3("C:\\advent-of-code\\input-day3.txt");

            string answer = day3.FinalAnswerPart1();
            
            Assert.Equal("173", answer);
        }
        [Fact]
        public void Day3Part2()
        {
            Day3 day3 = new Day3("C:\\advent-of-code\\input-day3.txt");

            string answer = day3.FinalAnswerPart2();
            
            Assert.Equal("4385176320", answer);
        }
        [Fact]
        public void Day4Part1()
        {
            Day4 day4 = new Day4("C:\\advent-of-code\\input-day4.txt");

            string answer = day4.FinalAnswerPart1();
            
            Assert.Equal("230", answer);
        }
        [Fact]
        public void Day4Part2()
        {
            Day4 day4 = new Day4("C:\\advent-of-code\\input-day4.txt");

            string answer = day4.FinalAnswerPart2();
            
            Assert.Equal("", answer);
        }
        [Fact]
        public void Day5Part1()
        {
            Day5 day5 = new Day5("C:\\advent-of-code\\input-day5.txt");

            string answer = day5.FinalAnswerPart1();
            
            Assert.Equal("822", answer);
        }
        [Fact]
        public void Day5Part2()
        {
            Day5 day5 = new Day5("C:\\advent-of-code\\input-day5.txt");

            string answer = day5.FinalAnswerPart2();
            
            Assert.Equal("705", answer);
        }
    }
}