using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodingInterview.chapter01
{
    internal class _1_1_IsUnique
    {
        public bool IsUnique(string input)
        {
            if (input.Length > 128) return false;

            bool[] charset = new bool[128];

            for(int i = 0; i < input.Length; i++)
            {
                char a = input[i];
                if(charset[a])
                {
                    return false;
                }
                charset[a] = true;
            }           
            return false;
        }
    }
}
