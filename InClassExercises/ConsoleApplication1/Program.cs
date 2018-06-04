using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

// Excercise 1
            //displays a predefined number of lines with 5 astrix on each line
            const int numberOfLines = 5;
            int i = 0;
            Console.WriteLine("\n\n");
            do
            {
                Console.WriteLine("     *****\n\n");
                i++;
            } while (i < numberOfLines);

            transitionMsg();

            Console.Clear();

//Excercise 2
            //gets the user's age and uses it to display a message

            string age = getValidEntry("Please enter your age:", "Positive Integer",
                                        "You must enter a positive integer value.", "");

            printOutput(age, "\n\n     You are " + age + " years old.");

            transitionMsg();

            Console.Clear();

//Excercise 3
            //simply displays an integer, a real number, and a string

            int intNum = 10;
            double floatNum = 12.5;
            string str = "C# Programming";

            Console.WriteLine("\n\n     The output for Excercise #3 is as follows:" +
                              "\n\n          " + intNum +
                              "\n          " + floatNum +
                              "\n          " + str);

            transitionMsg();

            Console.Clear();

//Excercise 4
            //gets the user's name and uses it to display a message

            string name = getValidEntry("Please enter your name:", "Alpha String",
                                        "You may only use upper or lower case letters", "");

            printOutput(name, "\n\n     Hello " + name + "!");

            transitionMsg();

            Console.Clear();

//Exercise 5


            Console.WriteLine("\n\n     We will now do some calculations based on numbers you enter...");

            string str1 = getValidEntry("Enter the first number: ", "Positive Integer", "You must enter a positive integer value.",
                                             "0");
            string str2 = getValidEntry("Enter the second number: ", "Positive Integer", "You must enter a positive integer value.",
                                             "0");
            int firstNum = int.Parse(str1);
            int secondNum = int.Parse(str2);

            Console.WriteLine("\n\n     Based on the numbers you entered, the following calculations are the result...\n\n");

            Console.WriteLine("     " + str1 + " + " + str2 + " = " + (firstNum + secondNum));
            Console.WriteLine("     " + str1 + " - " + str2 + " = " + (firstNum - secondNum));
            Console.WriteLine("     " + str1 + " * " + str2 + " = " + (firstNum * secondNum));
            Console.WriteLine("     " + str1 + " / " + str2 + " = " + (firstNum / secondNum));
            Console.WriteLine("     " + str1 + " mod " + str2 + " = " + (firstNum % secondNum));

            transitionMsg();

            Console.Clear();

            //Exercise 6 and Exercise 7
            //The user is prompted to enter the number of values they wish to find the average of.
            //They are then prompted to enter each value
            //Finaly, a message is diplayed showing each value and the caluclated average

            string answer;

            do
            {
                Console.Clear();
                string operation = getValidEntry("\n\n     Enter the letter corresponding to operation you'd like to perform:" +
                                             "\n          <+> for addition" +
                                             "\n          <-> for subtracion" +
                                             "\n          <*> for multiplication" +
                                             "\n          </> for division" +
                                             "\n          <a> for average", "Operators", "Invalid entry", "+");

                calcList(operation);

                answer = getValidEntry("\n\n     Would you like to perform another calculation? (<y> or <n>)",
                                              "Y or N", "Invalid Entry", "n");

            } while (answer == "y" || answer == "Y");

            Console.Clear();

            //Exercise 8
            //gets a string from the user and displays it backwards

            str = getValidEntry("\n\n     Enter a word or words and I will spell them backwards for you:",
                                        "Alpha String", "Invalid Entry", "");

            string backStr = "";

            for (i = str.Length - 1; i >= 0; i--)
            {
                backStr = backStr + str[i];
            }

            Console.WriteLine("\n\n     Your line, written backward is: " + backStr);

            transitionMsg();

            Console.Clear();

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n" +
                              "\n\n               *************************************************\n" + 
                                  "               ** Congratulations! You've made it to the end! **\n" +
                                  "               *************************************************");

            Console.ReadKey();

        }//end main module

//submodules
        static string promptForInput(string prompt)
        //Prompts user for input and reads into memory
        {
            Console.WriteLine("\n\n     "+ prompt);
            return Console.ReadLine();
        }

        static string getValidEntry(string prompt, string dataType, string errMsg, string defltStr)
        //gets user input and sends it to a validation algorithm
        //user has 3 tries to input valid data
        //if unsuccesful after 3 tries, the given default string is returned

        {
            int count = 0;
            string tries = "tries";
            string userInput;

            do
            {
                userInput = promptForInput(prompt);

                if (!validate(userInput, dataType))
                {
                    //User gets 3 tries to make a valid entry
                    count++;
                    if (count <= 2)
                    {
                        if (count == 2)
                        {
                            tries = "try";
                        }

                        Console.WriteLine("\n\n          **ERROR**" +
                                          "\n\n     " + errMsg +
                                          "\n\n     You have " + (3 - count) + " more " + tries +
                                          " to enter it correctly");
                    }
                }
            } while (!validate(userInput, dataType) && count < 3);

            if (count == 3)
            {
                Console.WriteLine("\n\n          **ERROR**" +
                                  "\n\n     You have exceeded the maximum number of attempts.");
                return defltStr;
            }
            else return userInput;
        }

        static bool validate(string str, string dataType)
        //validates data based on passed datatType
        {
            switch (dataType)
            {
                case "Positive Integer":
                    int value;
                    if (int.TryParse(str, out value) && value > 0)
                    {
                        return true;
                    }
                    else return false;
             
                case "Alpha String":
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (!validChar(str[i]) && str == " ")
                        {
                            return false;
                        }
                    }
                    return true;
                case "Operators":
                    if (str == "+" || str == "-" || str == "*" || str == "/" || str == "a" || str == "A")
                    {
                        return true;
                    }
                    else return false;
                case "Y or N":
                    if (str == "y" || str == "Y" || str == "n" || str == "N")
                    {
                        return true;
                    }
                    else return false; 

                default: return false;
            }
        }

        static bool validChar(Char ch)
        //returns true if passed character is an upper or lower case letter
        {
            if (Char.IsLetter(ch))
            {
                return true;
            }
            else return false;
        }

        static void printOutput(string str, string msg)
        //prints given output message 
        {
            if (str.Length > 0)
            {
                Console.WriteLine(msg);
            }
        }

        static void transitionMsg()
        //prints a transition message at the end of each excercise
        {
            Console.WriteLine("\n\n     Press <enter> to continue...");
            Console.ReadKey();
        }

        static string ToOrdinal(int num)
        //returns the passed number with an added suffix to create an ordinal number like 1st, 2nd, 3rd, etc. as a string
        {
            string suffix = "th";
            int lastTwoNum = num % 100;     //gets the last two digits of the passed integer

            if (lastTwoNum < 11 || lastTwoNum > 13)
            {
                switch (lastTwoNum % 10)    //gets the last digit of the passed integer
                {
                    case 1:
                        suffix = "st";
                        break;
                    case 2:
                        suffix = "nd";
                        break;
                    case 3:
                        suffix = "rd";
                        break;
                    default:
                        suffix = "th";
                        break;

                }
            }
            return Convert.ToString(num) + suffix;
        }

        static void calcList(string operation)
        //performs a calculation, based on the passed string, on a list of values provided by the user
        {
            int maxValues;
            string valueSeparator;

            //sets the seperator that will be used in final calculation display
            switch (operation)
            {
                case "*":
                    valueSeparator = " x ";
                    break;
                case "+":
                    valueSeparator = " + ";
                    break;
                case "-":
                    valueSeparator = " - ";
                    break;
                case "/":
                    valueSeparator = " / ";
                    break;
                default:
                    valueSeparator = ", ";
                    break;
            }

            maxValues = int.Parse(getValidEntry("     How many values would you like to operate on?", "Positive Integer",
                                      "     You must enter a positive integer value", "0"));

            //creates an array to hold the values to be operated on
            int[] intArray = new int[maxValues];

            //intializes total and populates first element of array  with the first value from user
            int total = intArray[0] = int.Parse(getValidEntry("Enter the 1st number: ", "Positive Integer",
                                                "You must enter a positive integer", "0"));

            string valueList = intArray[0] + valueSeparator;

            for (int i = 1; i < maxValues; i++)
            {
                //gets value from user
                intArray[i] = int.Parse(getValidEntry("Enter the " + ToOrdinal(i + 1) + " number: ", "Positive Integer",
                                                      "You must enter a positive integer", "0"));

                //accumulates the total based on passed operation
                switch (operation)
                {
                    case "*":
                        total = total * intArray[i];
                        break;
                    case "-":
                        total = total - intArray[i];
                        break;
                    case "/":
                        total = total / intArray[i];
                        break;
                    default:
                        total = total + intArray[i];
                        break;
                }

                //accumulates a string with each value entered by user, to be used in final calculation display
                if (i != maxValues - 1)
                {
                    valueList = valueList + intArray[i] + valueSeparator;
                }
                else
                {
                    if(valueSeparator == ", ")
                    {
                        valueList = valueList + "and " + intArray[i] + " ";
                    }
                    else
                    {
                        valueList = valueList + intArray[i] + " = ";
                    }
                }
            }

            //displays inputed values along with result of calculation
            if(operation == "a" || operation == "A")
            {
                Console.WriteLine("\n\n     The average of " + valueList + "is: " + (total / maxValues));
            }
            else
            {
                Console.WriteLine("\n\n     " + valueList + total);
            }
        }
    }
}
