using System;
using System.Threading;

namespace Project
{
    class Project1
    {
        public static string name;
        static void Main()
        {
            string uInput;
            int input;
            do
            {

                Console.WriteLine("Hardware                 1");
                Console.WriteLine("Networking/Internet      2");
                Console.WriteLine("Device/Phone/Tablet       3");
                Console.WriteLine("I dont know              4");
                Console.WriteLine("Close                    5");
                input = Convert.ToInt32(Console.ReadLine());


                switch (input)
                {

                    case 1:
                        Hardware();
                            break;

                    case 2:
                        Networking();

                        break;


                    case 3:

                        Device();
                        break;

                    case 4:

                        Dontknow();
                        break;

                    case 5:
                        uInput = "5";
                        break;

                           
                        





                }




            } while (uInput != "5");











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

        public static string UserName()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            return name;
        }

        static void Q3()
        {
            string answer, answer2, answer3, answer4, answer5, answer6;
            bool check = false;
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
                        if (answer3.Contains("y"))
                        {
                            Console.WriteLine("Are you sure you are having hardware problems?");
                            answer4 = Console.ReadLine();
                            answer4 = answer4.ToLower();
                            
                            if (answer4.Contains("y"))
                            {
                                Console.WriteLine("Are you sure it is cable related?");
                                answer5 = Console.ReadLine();
                                answer5 = answer5.ToLower();

                                if (answer5.Contains("y"))
                                {
                                    Console.WriteLine("Have you ever had cable problems before?");
                                    answer6 = Console.ReadLine();
                                    answer6 = answer6.ToLower();

                                    if (answer6.Contains("y"))
                                    {
                                        Console.WriteLine("It is possible that you have a problem with the cables and you may have to replace them.");
                                        //change back to menu
                                    }
                                    else
                                    {
                                        Console.WriteLine("Make sure all cables are placed into the correct slot");
                                        //change back to menu
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Make sure all cables are placed into the correct slot");
                                    //change back to menu
                                }
                            }
                            else
                            {
                                check = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Try unplugged and re-plugging your cables.");
                            //change back to menu
                        }
                        break;
                    case "inside":
                    case "in":
                        Console.WriteLine("");          //Nabeel do this
                        break;
                }
                if (check == true)
                {
                    Console.WriteLine($"Last time I asked you that question you gave me a different answer, {name}. Please don't lie to me.");
                    //change back to menu
                }

            }

        }





        ////////////Seymours Zone\\\\\\\\\\\
        ///


        static void Networking()


        {
            Console.WriteLine("Hello Is your Networking Issue Device Related Y or N");

























































        }










        static void Unsure()
        {
            string answer, answer2, answer3
        }


















































        //////////////////////Casssidy's zone\\\\\\\\\\\\\\\\\\\\\\\\\\\
        //////////////////////Seymore's zone\\\\\\\\\\\\\\\\\\\\\\\\\\\


































































































        //////////////////////Seymore's zone\\\\\\\\\\\\\\\\\\\\\\\\\\\
        //////////////////////Nabeel's zone\\\\\\\\\\\\\\\\\\\\\\\\\\\


































































































        //////////////////////Nabeel's zone\\\\\\\\\\\\\\\\\\\\\\\\\\\
        //////////////////////Bradley's zone\\\\\\\\\\\\\\\\\\\\\\\\\\\







        static void Q4 ()    //Mobile devices and tablets
        {
            string answer, answer2, answer3;
            Console.WriteLine("Are you using a phone or a tablet?");
            answer = Console.ReadLine();
            answer.ToLower();
            if (answer == "phone")
            {
                Console.WriteLine("Is it an Android or an apple product?");
                answer2 = Console.ReadLine();
                answer2.ToLower();
                if (answer2 == "apple")
                {
                    //call for switch 
                }
                if (answer2 == "android")
                {

                }
            
            }
            else if (answer == "tablet")
            {
                Console.WriteLine("Is it an Android or an apple product?");
                answer3 = Console.ReadLine();
                answer3.ToLower();
                if (answer3 == "apple")
                {

                }

            }
            else
            {
                Console.WriteLine("");
                //call for switch
            }
        }

































































































        //////////////////////Bradley's zone\\\\\\\\\\\\\\\\\\\\\\\\\\\


































































    }
}
