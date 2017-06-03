using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Balanced_Parentheses
{
    class BalancedParentheses
    {
        static void Main()
        {
            var sequence = Console.ReadLine();
            var stack = new Stack<char>();
            var check = true;

            foreach (char paren in sequence)
            {
                switch (paren)
                {
                    case '[':
                    case '(':
                    case '{':
                        stack.Push(paren);
                        break;

                    case '}':
                        if (!stack.Any())
                        {
                            check = false;
                        }else if (stack.Pop() != '{')
                        {
                            check = false;
                        }
                        break;
                    case ')':
                        if (!stack.Any())
                        {
                            check = false;
                        }
                        else if (stack.Pop() != '(')
                        {
                            check = false;
                        }
                        break;
                    case ']':
                        if (!stack.Any())
                        {
                            check = false;
                        }
                        else if (stack.Pop() != '[')
                        {
                            check = false;
                        }
                        break;
                }
                if (!check)
                {
                    break;
                }
            }
            Console.WriteLine(check ? "YES" : "NO");

        }
    }
}
