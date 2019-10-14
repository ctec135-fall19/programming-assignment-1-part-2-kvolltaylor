/*
Author: Katrina Voll-Taylor
Date: 9 October 2019
CTEC 135: Microsoft Software Development with C#

Module 2, Programming Assignment 1 Part 2, Problem 2

   Iteration

    For this problem print out the numbers 1-5 using several different loop structures:

        - Region 1: print 1-5 with spaces between the numbers on a single line using a 
          for loop
        - Region 2: print 1-5 with spaces between the numbers on a single line using a 
          while loop
        - Region 3: print 1-5 with spaces between the numbers on a single line using a 
          do/while loop
        - HINT: use Write() instead of WriteLine() in the loop body. 
        Follow the loop with a WriteLine() call to insert the newline character at the 
        end of the sequence.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 2 - Iteration Constructs");
            Console.WriteLine();

            #region 1: for loop
            Console.WriteLine("For loop example:");
            for (int i = 1; i < 6; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region 2: while loop
            Console.WriteLine("While loop example:");
            int j = 1;
            while (j < 6)
            {
                Console.Write("{0} ", j++);
            }
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region 3: do/while loop
            Console.WriteLine("Do/while loop example:");
            int k = 0;
            int[] l = { 1, 2, 3, 4, 5 };
            do
            {
                Console.Write(l[k++] + " ");
            } while (k < l.Length);
            Console.WriteLine();
            Console.WriteLine();
            #endregion
        }
    }
}
