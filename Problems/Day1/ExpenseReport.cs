using System;
using System.Collections.Generic;

namespace Problems.Day1
{
    public class ExpenseReport
    {

        private List<int> expenses;
        
        public ExpenseReport(List<int> expenses)
        {
            this.expenses = expenses;
        }

        private Tuple<int, int> Find2020Pair()
        {
            int currentIndex = 0;

            do
            {
                foreach (var expense in expenses)
                {
                    int sumValue = expenses[currentIndex] + expense;
                    if (sumValue == 2020)
                    {
                        return new Tuple<int, int>(expenses[currentIndex], expense);
                    }
                }
                currentIndex++;
            } while (currentIndex <= expenses.Count - 1);
            return new Tuple<int, int>(0, 0);
        }
        
        private Tuple<int, int, int> Find2020Triple()
        {
            int currentIndex = 0;

            do
            {
                
                
                foreach (var expenseOuter in expenses)
                {
                    foreach (var expenseInner in expenses)
                    {
                        int sumValue = expenses[currentIndex] + expenseOuter + expenseInner;
                        if (sumValue == 2020)
                        {
                            return new Tuple<int, int, int>(expenses[currentIndex], expenseOuter, expenseInner);
                        }
                    }
                }
                currentIndex++;
            } while (currentIndex <= expenses.Count - 1);
            return new Tuple<int, int, int>(0, 0, 0);
        }

        public int GetFinalAnswerPart1()
        {
            Tuple<int, int> Pair = Find2020Pair();
            int MultipliedAmount = Pair.Item1 * Pair.Item2;
            Console.WriteLine("Day 1 Part 1 Final Answer:");
            Console.WriteLine($"2020 Pair is {Pair.Item1}  {Pair.Item2}");
            Console.WriteLine($"Multiplied Amount is {MultipliedAmount}");

            return MultipliedAmount;
        }
        
        public int GetFinalAnswerPart2()
        {
            Tuple<int, int, int> Pair = Find2020Triple();
            int MultipliedAmount = Pair.Item1 * Pair.Item2 * Pair.Item3;
            Console.WriteLine("Day 1 Part 2 Final Answer:");
            Console.WriteLine($"2020 Triple Tuple is {Pair.Item1}  {Pair.Item2} {Pair.Item3}");
            Console.WriteLine($"Multiplied Amount is {MultipliedAmount}");

            return MultipliedAmount;
        }
    }
}