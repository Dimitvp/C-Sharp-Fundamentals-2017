using System;

namespace _03.Formatting_Numbers
{
    class FormattingNumbers
    {
        static void Main()
        {
            var splitter = new char[] {' ', '\t','\n'};

            var input = Console.ReadLine().Split(splitter, StringSplitOptions.RemoveEmptyEntries);

            var firstNum = int.Parse(input[0]);
            var secondNum = double.Parse(input[1]);
            var thirdNum = double.Parse(input[2]);

            //First way for hexadecimel
            var hexDecimelNum = firstNum.ToString("X");
            //Second way for hexadecimel
            //for (int i = 0; i < UPPER; i++)
            //{
            //    firstNum/16
            //}

            var binaryNum = Convert.ToString(firstNum, 2);
            
            Console.WriteLine($"|{hexDecimelNum.PadRight(10)}" +
                              $"|{binaryNum.PadLeft(10, '0').Substring(0,10)}|" +
                              $"{secondNum.ToString("0.00").PadLeft(10)}" +
                              $"|{thirdNum.ToString("0.000").PadRight(10)}|");

        }
    }
}
