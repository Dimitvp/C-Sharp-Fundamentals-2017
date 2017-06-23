using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft
{
    public class RepositoryFilters
    {
        public static void FilterAndTake(Dictionary<string, List<int>> wantedData, string wantedFilter, int studentToTake )
        {
            if (wantedFilter == "excellent")
            {
                FilterAndTake(wantedData, x => x >= 5, studentToTake);
            }
            else if(wantedFilter == "average")
            {
                 FilterAndTake(wantedData, x => x < 5 && x >= 3.5, studentToTake);
            }else if (wantedFilter == "poor")
            {
                FilterAndTake(wantedData, x => x < 3.5, studentToTake);
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.InvalidStudentFilter);
            }
        }

        private static void FilterAndTake(Dictionary<string, List<int>> wantedData, Predicate<double> givenFilter, int studentToTake)
        {
            int counterForPrinted = 0;
            foreach (var userName_Points in wantedData)
            {
                if (counterForPrinted == studentToTake)
                {
                    break;
                }

                double averageScore = userName_Points.Value.Average();
                double percentageOfFullfilment = averageScore / 100;
                double mark = percentageOfFullfilment * 4 + 2;
                if (givenFilter(mark))
                {
                    OutputWriter.PrintStudent(userName_Points);
                    counterForPrinted++;
                }
            }
        }
    }
}
