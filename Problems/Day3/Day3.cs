using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Problems.Day3
{
    public class Day3 : Problem
    {
        private List<string> inputData;

        public Day3()
        {
            string[] input = File.ReadAllLines("C:\\advent-of-code\\input-day3.txt");
            inputData = new List<string>(input);
        }
        private double ComputeSlopeTreeHits(int downSpeed, int velocity)
        {
            int positionCounter = 0;
            int lineCounter = 0;
            int treeCounter = 0;

            do
            {
                string slope = inputData[lineCounter];
                if (positionCounter >= slope.Length)
                {
                    int amountOver = positionCounter - slope.Length;
                    positionCounter = amountOver;
                }

                char[] currentLine = slope.ToCharArray();

                if (currentLine[positionCounter] == '#')
                {
                    treeCounter++;
                }
                
                positionCounter += velocity;
                lineCounter += downSpeed;

            } while (lineCounter < inputData.Count);

            return treeCounter;
        }

        public string FinalAnswerPart1()
        {
            return ComputeSlopeTreeHits(1, 3).ToString();
        }

        public string FinalAnswerPart2()
        {

            double total = ComputeSlopeTreeHits(1, 1) *
                           ComputeSlopeTreeHits(1, 3) *
                           ComputeSlopeTreeHits(1, 5) *
                           ComputeSlopeTreeHits(1, 7) *
                           ComputeSlopeTreeHits(2, 1);
            
            return total.ToString();

        }
    }
}