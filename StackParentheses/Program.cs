using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isValidString("}((())))")); 
        }
        public static bool isValidString(string str)
        {
            Stack<char>stack = new Stack<char>();

            if (str[0] != '(' && str[0] != '{' && str[0] != '[')
            {
                return false;

            }
            
            foreach (char c in str)
            {
                    if(c != ')' && c != '}' && c != ']')
                    {
                        stack.Push(c);
                        continue;
                    }
                char current = stack.Peek();
                if (current == 40 && c == 41 || current == 90 && c == 93 || current == 123 && c == 125)
                {
                    stack.Pop();

                }
                //
                     
            }
            return stack.Count == 0 ? true : false;
            
        }
    }
}
