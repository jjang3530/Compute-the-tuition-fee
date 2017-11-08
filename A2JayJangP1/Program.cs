/* Program ID: A2JayJangP1
 * Purpose: Assignment 2 Part 1
 * Revision History:
 * Jay Jang - Feb 12, 2017
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2JayJangP1
{
    class Program
    {
        public static string readInputString(string input)
        {
            string stringInput;
            do
            {
                Console.Write(input);
                stringInput = Console.ReadLine();
            } while (stringInput == "");
            return stringInput;
        }

        public static void OccuredError(string inputError)
        {
            Console.WriteLine(
                "An Error has occured Please enter your information again.");
        }

        static void Main(string[] args) // main start
        {
            //declaration variables
            string inputError;
            string inputAge;
            int inputIntAge;
            double baseTuition;
            string inputStudentType;
            string internationalStudent;
            double internationalStudentFee;
            string registrationSemester;
            string registeredSemester;
            double registrationFee;
            double totalExHST;
            double totalHST;
            double finalTotal;

            //initialize variables
            inputError = "";
            inputAge = "";
            inputIntAge = 0;
            baseTuition = 0;
            inputStudentType = "";
            internationalStudent = "";
            internationalStudentFee = 0;
            registrationSemester = "";
            registeredSemester = "";
            registrationFee = 0;
            totalExHST = 0;
            totalHST = 0;
            finalTotal = 0;

            //Ask about age
            inputAge = readInputString("Please enter your age: ");
            inputIntAge = int.Parse(inputAge);
            Console.WriteLine("  Your age is " + inputIntAge);

            if (0 < inputIntAge && inputIntAge <= 18)
            {
                baseTuition = 300;
            }
            else if (19 <= inputIntAge && inputIntAge <= 49)
            {
                baseTuition = 500;

            }
            else if (50 <= inputIntAge)
            {
                baseTuition = 400;

            }
            else
            {
                OccuredError(inputError);
                return;
            }

            Console.WriteLine(""); //Linechange

            //ask about student type
            Console.WriteLine("Please choose your student type:");
            Console.WriteLine("1. Canadian Citizen");
            Console.WriteLine("2. International Student");
            inputStudentType = readInputString("Answer is (1 or 2): ");
    
            if (inputStudentType == "1")
            {
                internationalStudentFee = 0;
                internationalStudent = "NO";
                Console.WriteLine("  You are a Canadian Citizen");
            }
            else if (inputStudentType == "2")
            {
                internationalStudentFee = 100;
                internationalStudent = "YES";
                Console.WriteLine("  You are an International Student");
            }
            else
            {
                //internationalStudent = "ERROR";  // No Need
                OccuredError(inputError);
                return;
            }

            Console.WriteLine(""); //Linechange


            //Ask semester
            Console.WriteLine("Please choose your registered semester: ");
            Console.WriteLine("1. Fall   months(Sept., Oct., Nov. or Dec.)");
            Console.WriteLine("2. Winter months(Jan., Feb., Mar. or Apr.)");
            Console.WriteLine("3. Summer months(May., Jun., Jul. or Aug.)");

            registeredSemester = readInputString("Answer is (1 or 2 or 3): ");
            switch (registeredSemester)
            {
                case "1":
                    registrationFee = 250;
                    registrationSemester = "FALL";
                    Console.WriteLine("  You registered in Fall semester");
                    break;
                case "2":
                    registrationFee = 220;
                    registrationSemester = "WINTER";
                    Console.WriteLine("  You registered in Winter semester");
                    break;
                case "3":
                    registrationFee = 50;
                    registrationSemester = "SUMMER";
                    Console.WriteLine("  You registered in Summer semester");
                    break;
                default:                
                    OccuredError(inputError);
                    return;
            }

            // Total amount
            totalExHST = baseTuition + internationalStudentFee + registrationFee;
            totalHST = totalExHST * 0.13;
            finalTotal = totalExHST + totalHST;

            Console.WriteLine(""); //Line Change

            //Line division
            Console.WriteLine("****************************************");
            Console.WriteLine("The Student's age: "+ inputAge);
            Console.WriteLine("International Student: "+ internationalStudent);
            Console.WriteLine("Registration Semester: "+ registrationSemester);
            Console.WriteLine(""); // Line Change
            Console.WriteLine("Base Tuition: " + baseTuition.ToString("c"));
            Console.WriteLine("International Student fee "
                              + internationalStudentFee.ToString("C"));
            Console.WriteLine("Registration Fee for semester: "
                              + registrationFee.ToString("C"));
            Console.WriteLine("Total HST: "+ totalHST.ToString("C"));
            Console.WriteLine(""); //Line change
            Console.WriteLine("Final Total: "+ finalTotal.ToString("C"));
            Console.WriteLine("****************************************");
            //Line division

            Console.WriteLine(""); //Line Change
        }
    }
}







            
            
           