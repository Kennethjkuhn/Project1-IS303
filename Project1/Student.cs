using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Student : Person
    {
        private double homeWorkAvg;
        private double quizAvg;
        private double projectAvg;
        private double testAvg;
        private double finalGrade;
        private char letterGrade;

        public void setHomeWorkAvg(double currHW)
        {
            homeWorkAvg = currHW;
        }

        public void setQuizAvg(double currQuiz)
        {
            quizAvg = currQuiz;
        }

        public void setProjectAvg(double currProject)
        {
            projectAvg = currProject;
        }

        public void setTestAvg(double currTest)
        {
            testAvg = currTest;
        }



        public void calcGrade()
        {
            finalGrade = (homeWorkAvg * .15) + (quizAvg * .05) + (projectAvg * .4) + (testAvg * .4);

            if (finalGrade >= 90)
            {
                letterGrade = 'A';
            }
            else if (finalGrade >= 80)
            {
                letterGrade = 'B';
            }
            else if (finalGrade >= 70)
            {
                letterGrade = 'C';
            }
            else if (finalGrade >= 60)
            {
                letterGrade = 'D';
            }
            else
            {
                letterGrade = 'F';
            }
        }

        public string getFullName()
        {
            return lastName + ", " + firstName;
        }

        public void displayGrade()
        {
            Console.WriteLine("\n\tFinal grade: " + Math.Round(finalGrade, 2));
            Console.WriteLine("\tLetter grade: " + letterGrade);
        }

        
    }
}
