using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodingInterview.chapter01
{
    // time complexity -> O(n) -> can be agued to O(128) or O(c) where c is the length of input string
    // sapce complexity -> O(1)

    // the other solutions availabe are using binary search tree which can provide O(log n)
    internal class _1_1_IsUnique
    {
        // First question we can ask the interviewer, if input string is in ASCII
        // format or Unicode string. unicode string includes all the special characters
        // even the emojis. but ASCII just has english alphabets, numbers and english symbols.
        // ref for difference between: https://www.geeksforgeeks.org/ascii-vs-unicode/
        public bool IsUnique(string input)
        {
            // maximum length is 128 for ASCII
            if (input.Length > 128) return false;

            // by default, all the values will be false.
            bool[] charset = new bool[128];

            for (int i = 0; i < input.Length; i++)
            {
                char a = input[i];
                if (charset[a]) // this will check if char is present.
                {
                    return false;
                }
                charset[a] = true;
            }
            return false;
        }
    }
}
