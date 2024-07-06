using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'minimumBribes' function below.
     *
     * The function accepts INTEGER_ARRAY q as parameter.
     */

    public static void minimumBribes(List<int> q)
    {
        int totalBribes = 0;
        int n = q.Count;

        for (int i = 0; i < n; ++i)
        {
            int originalPosition = q[i] - 1;
            int currentPosition = i;

            if (originalPosition - currentPosition > 2)
            {
                Console.WriteLine("Too chaotic");
                return;
            }

            for (int j = Math.Max(0, originalPosition - 1); j < currentPosition; ++j)
            {
                if (q[j] > q[i])
                {
                    totalBribes++;
                }
            }
        }

        Console.WriteLine(totalBribes);
    }    

}

class Solution
{
    public static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> q = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(qTemp => Convert.ToInt32(qTemp)).ToList();

            Result.minimumBribes(q);
        }
    }
}
