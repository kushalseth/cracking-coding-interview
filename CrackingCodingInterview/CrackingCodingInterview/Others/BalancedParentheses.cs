using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodingInterview.Others
{
    // Write a function to generate all possible n pairs of balanced parentheses.
    // https://www.geeksforgeeks.org/print-all-combinations-of-balanced-parentheses/
    internal class BalancedParentheses
    {
        public void GenerateParenthesis(int n)
        {
            char[] str = new char[2 * n];
            GetParanthesisList(0, 0, str, 0, n);


        }

        public static void GetParanthesisList(int open, int close, char[] s, int pos, int n)
        {
            //Console.WriteLine("*** original call *** " + " open = " + open + " close = " + close + " position = " + pos + " s = " + s.ToString());

            if (close == n)
            {
                for (int i = 0; i < s.Length; i++)
                    Console.Write(s[i]);

                Console.WriteLine();
                return;
            }

            else
            {
                if (open > close)
                {
                    s[pos] = ')';
                    //Console.WriteLine("*** open > close *** " + " open = " + open + " close = " + close + " position = " + pos + " s = " + s.ToString());
                    GetParanthesisList(open, close + 1, s, pos + 1, n);
                    Console.WriteLine("---> " + " open = " + open + " close = " + close + " position = " + pos + " s = " + s.ToString());

                }
                if (open < n)
                {
                    s[pos] = '(';
                    //Console.WriteLine("*** open < n *** " + " open = " + open + " close = " + close + " position = " + pos + " s = " + s.ToString());
                    GetParanthesisList(open + 1, close, s, pos + 1, n);
                    Console.WriteLine("---> " + " open = " + open + " close = " + close + " position = " + pos + " s = " + s.ToString());
                }
            }
        }
    }
}
