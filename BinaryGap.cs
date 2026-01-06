using System;
using System.Collections.Generic;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");
namespace BinaryGap
{
    class Solution
    {
        public int solution(int N)
        {
            int value = 0;
            var results = new List<int>();
            var binary = Convert.ToString(N, 2);
            Console.WriteLine(binary);
            foreach (var c in binary)
            {
                if (c.Equals('0'))
                {
                    value += 1;

                }
                else
                {
                    results.Add(value);
                    value = 0;
                }
            }
            return results.Max();
        }


    }

    class MainClass
    {

        public static void Main(string[] args)
        {
            var sol = new Solution();
            Console.WriteLine(sol.solution(1041));
        }
    }
}

