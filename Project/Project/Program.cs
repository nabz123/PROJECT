﻿using System;
using System.Threading;

namespace Project
{
    class Project1
    {
        static string name;
        static void Main()
        {
            //use main to test
        }

        static void QSwitch()   //add all questions into here that don't have follow up questions and we will put them into a switch later
        {
            Console.WriteLine("What broswer do you use?");
            Console.WriteLine("What operating system do you use?");
            Console.WriteLine("How old is your computer?");
            Console.WriteLine("When was the last time you shutdown your computer?");
            Console.WriteLine("When was the last time you backed up your computer?");
        }






        //////////////////////Casssidy's zone\\\\\\\\\\\\\\\\\\\\\\\\\\\


        static void Q2()    //ANTIVIRUS one main question with its follow on questions attached
        {
            string answer, answer2, answer3;
            Console.WriteLine("Do you have antivirus software installed on your computer?");
            answer = Console.ReadLine();
            answer.ToLower();
            if (answer.Contains("y"))
            {
                Console.WriteLine("Does your antivirus software regulary scan for viruses?");
                answer2 = Console.ReadLine();
                answer2.ToLower();
                if (answer2.Contains("y"))
                {
                    //call for switch 
                }
                else
                {
                    Console.WriteLine("Do you know how to set your software up to reguarly scan?");
                    answer3 = Console.ReadLine();
                    answer3.ToLower();
                    if (answer3.Contains("y"))
                    {
                        //call for switch
                    }
                    else
                    {
                        Console.WriteLine("It is important that your antivirus software runs scans regulary.");
                        //call for switch
                    }
                }
            }
            else
            {
                Console.WriteLine("It is important to install an antivirus software on your computer");
                //call for switch
            }
        }

        static void UserName()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
        }





































































            //////////////////////Casssidy's zone\\\\\\\\\\\\\\\\\\\\\\\\\\\
            //////////////////////Seymore's zone\\\\\\\\\\\\\\\\\\\\\\\\\\\


































































































            //////////////////////Seymore's zone\\\\\\\\\\\\\\\\\\\\\\\\\\\
            //////////////////////Nabeel's zone\\\\\\\\\\\\\\\\\\\\\\\\\\\


































































































            //////////////////////Nabeel's zone\\\\\\\\\\\\\\\\\\\\\\\\\\\
            //////////////////////Bradley's zone\\\\\\\\\\\\\\\\\\\\\\\\\\\









































































































            //////////////////////Bradley's zone\\\\\\\\\\\\\\\\\\\\\\\\\\\

































































        
    }
}
