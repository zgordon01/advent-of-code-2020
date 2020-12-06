using System.Collections.Generic;

namespace Problems.Day6
{
    public class QuestionGroup
    {
        public List<string> AnswerSets { get; set; }
        public List<char> UniqueQuestions { get; set; }
        
        public List<char> QuestionsEveryoneAnswered = new List<char>();

    }
}