﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<int> stack = new Stack<int>(input.Length);

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(' )
                {
                    stack.Push(i);
                }

                if (input[i] == ')')
                {
                    int start = stack.Pop();
                    Console.WriteLine(input.Substring(start, i - start + 1));
                }
            }
        }
    }
}
