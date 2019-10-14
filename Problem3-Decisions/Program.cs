/*
Author: Katrina Voll-Taylor
Date: 9 October 2019
CTEC 175: Microsoft Software Development with C#

Module 2, Programming Assignment 1 Part 2, Problem 3

   Decisions

        - Create methods for each of the actions. Each method should contain a 
          print statement with the text from the Actions part of the table as the 
          output. Note: these methods are at the same level as the Main() method and 
          should follow Main().

        - Region 1 ( inside Main() ):
            -create 3 nested loops, one for each condition.
            -in the body of the inner-most loop:
                - print a line stating the conditions.
                        For example:
                        Conditions: prints: False, 
                        flashing light: False, 
                        printer recognized: False

                - use if statements to call the appropriate methods to print 
                  out the possible actions.
                - use vertical spacing as appropriate to make the output readable.

        - Region 2 ( inside Main() ):
            - In a separate section of code implement a single for loop 
              that iterates from 0 to 7. The programmer's trick here is 
              to represent the condition values as a number. Using 0 for No 
              and 1 for Yes, the conditions can be converted to a binary number. 
              Use Printer prints as the most signicant bit, red light flashing 
              as the next most significant, and so one. If all conditions are Yes, 
              you get a binary number, 111 which translates to 7. Each column in 
              the table above can be labeled with a number using this system.

            - In the loop body implement a switch statement that uses the iteration 
              variable as its value. The code in each case will call the appropriate 
              methods based on the number (column in the table).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3Decisions
{
    class Program
    {
        //Main
        static void Main(string[] args)
        {
            #region Region 1:
            Console.WriteLine("REGION 1:" + "\n\n");

            // create variables to contain repeated strings 
            // so they don't have to be retyped over & over
            string conditionHeader = "Conditions:" + "\n" + 
                (string.Concat(Enumerable.Repeat("-",10))) + "- ";
            string actionHeader = "\t" + "Actions:" + "\n\t" + 
                (string.Concat(Enumerable.Repeat("-",7))) + "- ";

            string printPPNo = "Printer Prints: no; ";
            string printPPYes = "Printer Prints: yes; ";
            string printRLFNo = "Red Light Flashing: no; ";
            string printRLFYes = "Red Light Flashing: yes; ";
            string printPRNo = "Printer Recognized: no;" + "\n\n";
            string printPRYes = "Printer Recognized: yes;" + "\n\n";

            // Nested for loops: iterate though all various conditions 
th          // Input: conditions 
            // Process: iterate through each possibility, then each combinatiion
            // Output: human readable list of conditions and actions
            for (int printerPrints = 0;  printerPrints <= 1; printerPrints++){
                for (int redLightFlashing = 0; redLightFlashing <= 1; redLightFlashing++){
                    for (int printerRecognized = 0; printerRecognized <= 1; printerRecognized++){
                        // if/if else statements to test for conditions
                        if (printerPrints == 0 && redLightFlashing == 1 
                            && printerRecognized == 0){
                                Console.WriteLine (conditionHeader);
                                Console.Write(printPPNo + printRLFYes + printPRNo);
                                Console.WriteLine(actionHeader);
                                CheckPrinterCable();
                                EnsureSoftwareInstalled();
                                CheckInk();
                                Console.WriteLine();
                        } 
                        else if (printerPrints == 0 && redLightFlashing == 1 
                            && printerRecognized == 1){
                                Console.WriteLine(conditionHeader);
                                Console.Write(printPPNo + printRLFYes + printPRYes); 
                                Console.WriteLine(actionHeader);
                                CheckInk();
                                CheckForJam();
                                Console.WriteLine();
                        }
                        else if (printerPrints == 0 && redLightFlashing == 0 
                            && printerRecognized == 0){
                                Console.WriteLine(conditionHeader);
                                Console.Write(printPPNo + printRLFNo + printPRNo);
                                Console.WriteLine(actionHeader);
                                CheckPowerCable();
                                CheckPrinterCable();
                                EnsureSoftwareInstalled();
                                Console.WriteLine();
                        }
                        else if (printerPrints == 0 && redLightFlashing == 0 
                            && printerRecognized == 1){
                                Console.WriteLine(conditionHeader);
                                Console.Write(printPPNo + printRLFNo + printPRYes);
                                Console.WriteLine(actionHeader);
                                CheckForJam();
                                Console.WriteLine();
                        }
                        else if (printerPrints == 1 && redLightFlashing == 1 
                            && printerRecognized == 0){
                                Console.WriteLine(conditionHeader);
                                Console.Write(printPPYes + printRLFYes + printPRNo);
                                Console.WriteLine(actionHeader);
                                EnsureSoftwareInstalled();
                                Console.WriteLine();
                        }
                        else if (printerPrints == 1 && redLightFlashing == 1 
                            && printerRecognized == 1){
                                Console.WriteLine(conditionHeader);
                                Console.Write(printPPYes + printRLFYes + printPRYes);
                                Console.WriteLine(actionHeader);
                                CheckInk();
                                Console.WriteLine();
                        }
                        else if (printerPrints == 1 && redLightFlashing == 0 
                            && printerRecognized == 0){
                                Console.WriteLine(conditionHeader);
                                Console.Write(printPPYes + printRLFNo + printPRNo);
                                Console.WriteLine(actionHeader);
                                EnsureSoftwareInstalled();
                                Console.WriteLine();
                        }
                        else if (printerPrints == 1 && redLightFlashing == 0 
                            && printerRecognized == 1){
                                Console.WriteLine(conditionHeader);
                                Console.Write(printPPYes + printRLFNo + printPRYes);
                                Console.WriteLine(actionHeader);
                                Console.WriteLine("\t" 
                                    + "- Sorry, no recommended actions at this time.");
                                Console.WriteLine();
                        }

                    }
                }
            }
            #endregion
            Console.WriteLine((string.Concat(Enumerable.Repeat("-",75))) + "\n");

            #region Region 2:
            Console.WriteLine("REGION 2:" + "\n\n");

            // for loop with switch case
            // converted each set of conditions into a binary number value
            // for loop iterates through total number of condtion combinations
            // then switch case determines what to do depending
            // upon the value of i through each iterartion 
            // Input: each combination of conditions as represented by a binary number value 
            // Process: iterate through each combination of conditions
            // Output: human readable list of conditions and actions

            for (int i=0; i<=7; i++){
                switch (i)
                {
                    // for each case, print out conditions
                    // then call methods for the actions

                    // no, no, no ; 000
                    case 0:
                        Console.WriteLine(conditionHeader);
                        Console.Write(printPPNo + printRLFNo + printPRNo);
                        Console.WriteLine(actionHeader);
                        CheckPowerCable();
                        CheckPrinterCable();
                        EnsureSoftwareInstalled();
                        Console.WriteLine();
                        break;
                    // no, no, yes ; 001
                    case 1:
                        Console.WriteLine(conditionHeader);
                        Console.Write(printPPNo + printRLFNo + printPRYes);
                        Console.WriteLine(actionHeader);
                        CheckForJam();
                        Console.WriteLine();
                        break;
                    // no, yes, no ; 010
                    case 2:
                        Console.WriteLine (conditionHeader);
                        Console.Write(printPPNo + printRLFYes + printPRNo);
                        Console.WriteLine(actionHeader);
                        CheckPrinterCable();
                        EnsureSoftwareInstalled();
                        CheckInk();
                        Console.WriteLine();
                        break;
                    // no, yes, yes ; 011
                    case 3:
                        Console.WriteLine(conditionHeader);
                        Console.Write(printPPNo + printRLFYes + printPRYes); 
                        Console.WriteLine(actionHeader);
                        CheckInk();
                        CheckForJam();
                        Console.WriteLine();
                        break;
                    // yes, no, no ; 100
                    case 4:
                        Console.WriteLine(conditionHeader);
                        Console.Write(printPPYes + printRLFNo + printPRNo);
                        Console.WriteLine(actionHeader);
                        EnsureSoftwareInstalled();
                        Console.WriteLine();
                        break;
                    // yes, no, yes ; 101
                    case 5:
                        Console.WriteLine(conditionHeader);
                        Console.Write(printPPYes + printRLFNo + printPRYes);
                        Console.WriteLine(actionHeader);
                        Console.WriteLine("\t" 
                            + "- Sorry, no recommended actions at this time.");
                        Console.WriteLine();
                        break;
                    // yes, yes, no ; 110
                    case 6:
                        Console.WriteLine(conditionHeader);
                        Console.Write(printPPYes + printRLFYes + printPRNo);
                        Console.WriteLine(actionHeader);
                        EnsureSoftwareInstalled();
                        Console.WriteLine();
                        break;
                    // yes, yes, yes ; 111
                    case 7:
                        Console.WriteLine(conditionHeader);
                        Console.Write(printPPYes + printRLFYes + printPRYes);
                        Console.WriteLine(actionHeader);
                        CheckInk();
                        Console.WriteLine();
                        break;
                }
            }
        }
        #endregion

        #region Methods for Actions
        // create methods for each of the possible actions listed
        static void CheckPowerCable(){
            Console.WriteLine("\t" + "- Check the power cable");
        }
        static void CheckPrinterCable(){
            Console.WriteLine("\t" + "- Check the printer-computer cable");
        }
        static void EnsureSoftwareInstalled(){
            Console.WriteLine("\t" + "- Ensure printer software is installed");
        }
        static void CheckInk(){
            Console.WriteLine("\t" + "- Check/replace ink");
        }
        static void CheckForJam(){
            Console.WriteLine("\t" + "- Check for paper jam");
        }
        #endregion
    }
}