using Problems.Day1;
using Problems.Day2;
using Problems.Day3;
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
            Day3 day3 = new Day3();

            string answer = day3.FinalAnswerPart1();
            
            Assert.Equal("173", answer);
        }
        [Fact]
        public void Day3Part2()
        {
            Day3 day3 = new Day3();

            string answer = day3.FinalAnswerPart2();
            
            Assert.Equal("4385176320", answer);
        }
    }
}