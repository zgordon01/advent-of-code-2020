using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Xml.Linq;

namespace Problems.Day6
{
    public class Day6: Problem
    {
        private List<QuestionGroup> QuestionGroups = new List<QuestionGroup>();
        private Day6(){}
        
        public Day6(string filePath)
        {
            List<string> groupsInput;

            string rawInput = File.ReadAllText(filePath);
            groupsInput = new List<string>(rawInput.Split(separator: "\r\n\r\n"));
            groupsInput.ForEach(x =>
            {
                List<string> answerSets = x.Split("\r\n").ToList();
                List<char> questionsEveryoneAnswered = answerSets[0].ToList();
                
                answerSets.ForEach(set =>
                { // If you are reading this, I hate everything in this block... but it works.
                    foreach (char x in set)
                    {
                        if (!questionsEveryoneAnswered.Contains(x))
                        {
                            questionsEveryoneAnswered.Remove(x);
                        }

                        List<char> charsToRemove = new List<char>();
                        questionsEveryoneAnswered.ForEach(question =>
                        {
                            if (!set.Contains(question))
                            {
                                charsToRemove.Add(question);
                            }
                        });
                        charsToRemove.ForEach(chars =>
                        {
                            questionsEveryoneAnswered.Remove(chars);
                        });

                    }
                });

                QuestionGroups.Add(new QuestionGroup
                {
                    AnswerSets = answerSets,
                    UniqueQuestions = x.Replace("\r\n", "").Distinct().ToList(),
                    QuestionsEveryoneAnswered = questionsEveryoneAnswered
                });
            });
        }

        public string FinalAnswerPart1()
        {
            double answer = 0;
            QuestionGroups.ForEach(group => answer += group.UniqueQuestions.Count());

            return answer.ToString();
        }

        public string FinalAnswerPart2()
        {
            double answer = 0;
            QuestionGroups.ForEach(group => answer += group.QuestionsEveryoneAnswered.Count());


            return answer.ToString();
        }
    }
}