using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        //authors:
        //section 1
        //description: 

        static void Main(string[] args)
        {
            //declare variables and initialize array of student objects for later use
            int menuChoice = 0;
            bool menuChosen = false;
            int numStudents = 0;
            Student[] studentArray = null;

            //using a do while loop to keep the menu running until user inputs something other than 1 or 2
            //if 3 is entered it says 'exiting program...' but if anything else there is just a pause
            do
            {
                
                //display menu for user who will input 1, 2, or 3
                Console.WriteLine("\n\n1.\tNew Class List");
                Console.WriteLine("\n2.\tSearch for a Student");
                Console.WriteLine("\n3.\tExit");

                //get user input for menu selection
                menuChoice = Convert.ToInt32(Console.ReadLine());

                //if user chooses 1 and has not previously chosen 1, run through this if
                if (menuChoice == 1 && menuChosen == false)
                {
                    //set menu option 1 to chosen and then will not allow user to choose 1 again
                    menuChosen = true;

                    //get input from user for size of array of student objects
                    //initialize array given user input 
                    Console.WriteLine("\nEnter the number of students: ");
                    numStudents = Convert.ToInt32(Console.ReadLine());
                    studentArray = new Student[numStudents];

                    if (numStudents != 0)
                    {                      
                        //create student objects for each position in the array 
                        for (int i = 0; i < numStudents; i++)
                        {
                            //initialize object at position i
                            studentArray[i] = new Student();
                            
                            //call method and get input to set first name of student objects
                            Console.WriteLine("\nPlease enter the first name for student " + (i+1) + ": ");
                            studentArray[i].setFirstName(Console.ReadLine());
                            
                            //call method and get input to set last name for student objects
                            Console.WriteLine("\nPlease enter the last name for student " + (i + 1) + ": ");
                            studentArray[i].setLastName(Console.ReadLine());

                            //call method and get input to set homework average grade
                            Console.WriteLine("\nPlease enter the homework average for student " + (i + 1) + ": ");
                            studentArray[i].setHomeWorkAvg(Convert.ToDouble(Console.ReadLine()));

                            //call method and get input to set quiz average grade
                            Console.WriteLine("\nPlease enter the quiz average for student " + (i + 1) + ": ");
                            studentArray[i].setQuizAvg(Convert.ToDouble(Console.ReadLine()));

                            //call method and get input to set project average grade
                            Console.WriteLine("\nPlease enter the project average for student " + (i + 1) + ": ");
                            studentArray[i].setProjectAvg(Convert.ToDouble(Console.ReadLine()));

                            //call method and get input to set test average grade
                            Console.WriteLine("\nPlease enter the test average for student " + (i + 1) + ": ");
                            studentArray[i].setTestAvg(Convert.ToDouble(Console.ReadLine()));

                            //call method to calculate final grade with weights and determine final letter grade
                            studentArray[i].calcGrade();

                        }
                    }
                    //this will occur if user does not input anything for the student list
                    else if (numStudents == 0)
                    {
                        //not sure what to do if they enter 0 for the number of students in the array
                        //maybe allow them to re-enter student list?
                        Console.WriteLine("\nYou dont have any students to add? Okay.");
                    }
                }
                //give this output if user attempts to choose option 1 after already inputing a student list
                else if (menuChoice == 1 && menuChosen == true)
                {
                    Console.WriteLine("You have already created the list of students.");
                }
                //this option will only occur if the user has previously input a student list
                else if (menuChoice == 2 && menuChosen == true)
                {
                    //declare variables
                    string tempLast;
                    string tempFirst;
                    int currIndex = Int32.MaxValue;
                    //get input from user for a name to search for
                    Console.WriteLine("\nPlease enter a last name to search for: ");
                    tempLast = Console.ReadLine();
                    Console.WriteLine("Please enter a first name as well: ");
                    tempFirst = Console.ReadLine();

                    //run through entire array searching for given student
                    for(int i = 0; i < numStudents; i++)
                    {
                        //if position i of the array matches the input it will set the index to that position
                        if (studentArray[i].getFullName().Equals(tempLast + ", " + tempFirst))
                        {
                            currIndex = i;
                        }
                        else
                        {
                            //do nothing
                        }
                    }

                    //maxvalue represents the only value in which there was not a match found so this
                    //if will only display if a match was found
                    if (currIndex != Int32.MaxValue)
                    {
                        studentArray[currIndex].getFullName();
                        studentArray[currIndex].displayGrade();
                    }
                    //error message displayed if no match is found
                    else
                    {
                        Console.WriteLine("\nError: no student named " + tempFirst + " " + tempLast + " was found.");
                    }
                }
                //output if user attempts to search for a student without first inputting a student list
                else if (menuChoice == 2 && menuChosen == false)
                {
                    Console.WriteLine("\nYou haven't entered any students into the system yet!");
                }
                //the following will display if user chooses 3 and exits the program
                else if (menuChoice == 3)
                {
                    Console.WriteLine("\n\nPress enter to exit the program...");
                    Console.ReadLine();
                }

            }
            while (menuChoice != 3);
            
        }
    }
}
