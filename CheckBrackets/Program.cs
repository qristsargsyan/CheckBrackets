using System;
using System.Collections.Generic;

namespace CheckBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = "1+(3+2-(2+3)*4-((3+1)*(4-2)))";
            Stack<int> stack = new Stack<int>();

            bool correctBrackets = true;

            for (int i = 0; i < expression.Length; i++)
            {
                char ch = expression[i];

                if (ch == '(')
                {
                    stack.Push(i);
                }
                else if (ch == ')')
                {
                    if (stack.Count == 0)
                    {
                        correctBrackets = false;
                        break;
                    }
                    stack.Pop();                  
                }
            }
            if (stack.Count != 0)
            {
                correctBrackets = false;
            }
            Console.WriteLine("Are the brackets correct? " + correctBrackets);

        }
    }
}
