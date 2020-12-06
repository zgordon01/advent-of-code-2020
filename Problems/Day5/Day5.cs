using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Problems.Day5
{
    public class Day5: Problem
    {
        
        private List<string> inputData;
        private List<BoardingPassEntry> boardingPasses = new List<BoardingPassEntry>();
        private int highestFoundSeatId = 0;
        public Day5(string filePath)
        {
            string[] input = File.ReadAllLines(filePath);
            inputData = new List<string>(input);
        }

        private void DeserializeInputData()
        {
            inputData.ForEach(boardingPass =>
            {
                boardingPasses.Add(new BoardingPassEntry()
                {
                    rowSpecifiers = boardingPass.Substring(0, 7).ToCharArray(),
                    columnSpecifiers = boardingPass.Substring(7, 3).ToCharArray()
                });
            });
        }

        private List<int> ReducePlaneRows(ref List<int> planeRows, char rowSpecifier)
        {
            if (rowSpecifier == 'F')
            {
                planeRows.RemoveRange(planeRows.Count() / 2, planeRows.Count() / 2);
            }
            else if (rowSpecifier == 'B')
            {
                planeRows.RemoveRange(0, planeRows.Count() / 2);
            }

            return planeRows;
        }
        
        private List<int> ReducePlaneColumns(ref List<int> planeColumns, char columnSpecifier)
        {
            if (columnSpecifier == 'L')
            {
                planeColumns.RemoveRange(planeColumns.Count() / 2, planeColumns.Count() / 2);
            }
            else if (columnSpecifier == 'R')
            {
                planeColumns.RemoveRange(0, planeColumns.Count() / 2);
            }

            return planeColumns;
        }

        private void ParseBoardingPasses()
        {
            boardingPasses.ForEach(pass =>
            {
                List<int> planeRows = new List<int>{0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127};
                List<int> planeColumns = new List<int>{0, 1, 2, 3, 4, 5, 6, 7};

                foreach (char specifier in pass.rowSpecifiers)
                {
                    ReducePlaneRows(ref planeRows, specifier);
                }
                pass.row = planeRows[0];
                
                foreach (char specifier in pass.columnSpecifiers)
                {
                    ReducePlaneColumns(ref planeColumns, specifier);
                }
                pass.column = planeColumns[0];

                pass.seatID = (pass.row * 8) + pass.column;
                highestFoundSeatId = pass.seatID > highestFoundSeatId ? pass.seatID : highestFoundSeatId;
            });
        }

        public string FinalAnswerPart1()
        {
            DeserializeInputData();
            ParseBoardingPasses();
            
            return highestFoundSeatId.ToString();
        }

        public string FinalAnswerPart2()
        {
            DeserializeInputData();
            ParseBoardingPasses();
            
            List<BoardingPassEntry> sortedBoardingPassEntries = boardingPasses.OrderBy(pass => pass.seatID).ToList();
            int lastCheckedSeat = 12;//not sure why my seatIDs start at 13, so hardcoding this
            foreach (BoardingPassEntry boardingPassEntry in sortedBoardingPassEntries)
            {
                if (lastCheckedSeat != boardingPassEntry.seatID - 1)
                {
                    lastCheckedSeat += 1;
                    break;
                }

                lastCheckedSeat = boardingPassEntry.seatID;
            }

            return lastCheckedSeat.ToString();
        }
    }
}