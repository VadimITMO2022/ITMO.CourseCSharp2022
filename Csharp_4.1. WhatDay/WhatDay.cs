using System;  // using the System library in your project
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhatDay1
{
    class WhatDay  //  the class name of your entry-point class
    {
        static void Main(string[] args) // is the entry-point method of your program
        {
            //
            // Add code here
            //

            Console.Write("Please enter a day number between 1 and 365: ");
            string line = Console.ReadLine();
            int dayNum = int.Parse(line);
            int monthNum = 0;


            ////////////////////////////////////////////////////////////////////
            ////// Uncomment the code below  before Calculating           //////
            /////  the month and day pair from a day number               //////
            ////////////////////////////////////////////////////////////////////

                    if (dayNum <= 31) { // January
                        goto End;
                    } else {
                        dayNum -= 31; // dayNum = dayNum - 31
                        monthNum++; // monthNum = monthNum +1
            }
            
                    if (dayNum <= 28) { // February
                        goto End;
                    } else {
                        dayNum -= 28;
                        monthNum++;
                    }
            
                    if (dayNum <= 31) { // March
                        goto End;
                    } else {
                        dayNum -= 31;
                        monthNum++;
                    }
            
                    if (dayNum <= 30) { // April
                        goto End;
                    } else {
                        dayNum -= 30;
                        monthNum++;
                    }
            
                    if (dayNum <= 31) { // May
                        goto End;
                    } else {
                        dayNum -= 31;
                        monthNum++;
                    }
            
            
                    if (dayNum <= 30) { // June
                        goto End;
                    } else {
                        dayNum -= 30;
                        monthNum++;
                    }
            
                    if (dayNum <= 31) { // July
                        goto End;
                    } else {
                        dayNum -= 31;
                        monthNum++;
                    }
            
                    if (dayNum <= 31) { // August
                        goto End;
                    } else {
                        dayNum -= 31;
                        monthNum++;
                    }
            
                    if (dayNum <= 30) { // September
                        goto End;
                    } else {
                        dayNum -= 30;
                        monthNum++;
                    }
            
                    if (dayNum <= 31) { // October
                        goto End;
                    } else {
                        dayNum -= 31;
                        monthNum++;
                    }

            //////////////////////////////////////////////////////////////
            // TODO: Implement if statements for November and December ///
            //////////////////////////////////////////////////////////////

                    if (dayNum <= 30) { // November
                        goto End;
                    } else {
                        dayNum -= 30;
                        monthNum++;
                    }

                    if (dayNum <= 31) { // December
                        goto End;
                    } else {
                        dayNum -= 31;
                        monthNum++;
                    }


                      End:
                      string monthName;

            //////////////////////////////////////////////////////////////
            // TODO:												  ////
            //		Add an identifer label End below and              ////
            //		declare string variable							  ////
            //////////////////////////////////////////////////////////////

                    switch (monthNum) {
                    case 0 :
                        monthName = "January"; break;
                    case 1 :
                        monthName = "February"; break;
                    case 2 :
                        monthName = "March"; break;
                    case 3 :
                        monthName = "April"; break;
                    case 4 :
                        monthName = "May"; break;
                    case 5 :
                        monthName = "June"; break;
                    case 6 :
                        monthName = "July"; break;
                    case 7 :
                        monthName = "August"; break;
                    case 8 :
                        monthName = "September"; break;
                    case 9 :
                        monthName = "October"; break;
                    case 10:
                        monthName = "November"; break;
                    case 11:
                        monthName = "December"; break;
                    default:
                        monthName = "not done yet"; break;


                    //////////////////////////////////////////////////////////////////
                    // TODO: Implement the case 10 and case 11 for November         //
                    //       and December											//
                    //       Add a default label									//
                    //////////////////////////////////////////////////////////////////

            }

                   Console.WriteLine("{0} {1}", dayNum, monthName);
                   Console.Read();

        }
        // Don't modify anything below here
        static System.Collections.ICollection DaysInMonths
            = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

    }

}
