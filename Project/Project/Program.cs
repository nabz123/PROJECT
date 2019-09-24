using System;
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

        static void Q3()
        {
            string answer, answer2, answer3;
            Console.WriteLine("Are you having problems with your computers hardware?");
            answer = Console.ReadLine();
            answer = answer.ToLower();

            if (answer.Contains("y"))
            {
                Console.WriteLine("Do you believe the problems are happening outside the computer (such as cables), or inside the computer? Or are you not sure?");
                answer2 = Console.ReadLine();
                answer2 = answer2.ToLower();

               switch (answer2)
                {
                    case "cable":
                    case "cables":
                    case "outside":
                        Console.WriteLine("Have you tried unplugging and replugging-in your cables?");
                        answer3 = Console.ReadLine();
                        answer3 = answer3.ToLower();
                        break;
                    case "inside":
                    case "in":
                        Console.WriteLine("");
                        break;
                }
            }
        }



































































        //////////////////////Casssidy's zone\\\\\\\\\\\\\\\\\\\\\\\\\\\
        //////////////////////Seymore's zone\\\\\\\\\\\\\\\\\\\\\\\\\\\


































































































        //////////////////////Seymore's zone\\\\\\\\\\\\\\\\\\\\\\\\\\\
        //////////////////////Nabeel's zone\\\\\\\\\\\\\\\\\\\\\\\\\\\
        static void Hardware()
        {


            /*if (answer.Contains("y"))
            {
                Console.WriteLine("Do you believe the problems are happening outside the computer (such as cables), or inside the computer? Or are you not sure?");
                answer2 = Console.ReadLine();
                answer2 = answer2.ToLower();

                switch (answer2)
                {
                    case "cable":
                    case "cables":
                    case "outside":
                        Console.WriteLine("Have you tried unplugging and replugging-in your cables?");
                        answer3 = Console.ReadLine();
                        answer3 = answer3.ToLower();
                        break;
                    case "inside":
                    case "in":
                        Console.WriteLine("");
                        break;
                }
            }*/
            string answer,ans2;
            Console.WriteLine("Are you facing a Monitor issue Y or N?");
            answer = Console.ReadLine();
            answer = answer.ToLower();

            if (answer.Contains("y"))
            {
                Console.WriteLine("Do you believe this porblem is related to something such as cables? Or are you not sure?");
                ans2 = Console.ReadLine();
                ans2 = ans2.ToLower();

                switch (ans2)
                {
                    case "cables":
                    case "cable":
                        Console.WriteLine("Have you tried unplugging and replugging in your cables?");
                        break;
                    case "display":
                    case "light":
                    case "black screen":
                    case "blank screen":
                        Console.WriteLine("Is your device connect proplerly?");
                        break;

                }
            }
            else
            {
                string ans3, ans4,ans5,ans6;
                Console.WriteLine("Is your DESKTOP shtting off randomly? Y or N");
                ans3 = Console.ReadLine();
                ans3 = ans3.ToLower();
                if (ans3.Contains("y"))
                {
                    Console.WriteLine("Do ypu blieve this is a RAM or cables issue? Or are you not sure??");
                    ans4 = Console.ReadLine();
                    ans4 = ans4.ToLower();

                    switch (ans4)
                    {
                        case "cable":
                        case "cables":
                            Console.WriteLine("Is the cable loose? If so try pushing in?");
                            break;
                        case "RAM":
                            Console.WriteLine("If on a desktop have you tried push it in to place?");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Is your computer slow? Y or N");
                    ans5 = Console.ReadLine();
                    ans5 = ans5.ToLower();
                    if (ans5.Contains("y"))
                        Console.WriteLine("Do you bleive this is related to having many programs running or you don't have anymore storage remianing? Or are you not sure");

                }
            }
            


            //////////////////////Nabeel's zone\\\\\\\\\\\\\\\\\\\\\\\\\\\
            //////////////////////Bradley's zone\\\\\\\\\\\\\\\\\\\\\\\\\\\









































































































                //////////////////////Bradley's zone\\\\\\\\\\\\\\\\\\\\\\\\\\\


































































        }
}
