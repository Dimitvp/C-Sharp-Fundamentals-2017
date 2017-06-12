using System;
using System.Collections.Generic;
using System.Text;

namespace _08.Multiply_big_number
{
    class MultiplyBigNumber
    {
        static void Main()
        {
            var firstNum = new Stack<char>(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var result = new StringBuilder();
            var sum = 0;
            var reminder = 0;
            var multiplyer = 0;
            //TODO everything is wrong
            while (firstNum.Count != 0)
            {
                sum = multiplyer / 10 + reminder;
                reminder = 0;
                multiplyer = secondNum * int.Parse(firstNum.Pop().ToString());
                if (multiplyer + sum > 9)
                {
                    reminder = ((multiplyer % 10) + sum) / 10;
                    
                    result.Insert(0, reminder);
                }
                else
                {
                    result.Insert(0, (multiplyer % 10) + sum);
                }
            }

            result.Insert(0, multiplyer / 10);
            Console.WriteLine(result.ToString().TrimStart('0'));
        }
    }
}
