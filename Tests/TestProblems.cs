using Problems.Day1;
using Problems.Day2;
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
    }
}