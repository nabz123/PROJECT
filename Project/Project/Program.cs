using System;
using System.Threading;

namespace Project
{
    class Project1
    {
        public static string name;
        static void Main()
        {
            int input, count = 0;

            while (count != 1)
            {
                UserName();
                count++;
            }

            do
            {
                Console.Clear();
                Console.WriteLine($"Welcome to The Menu, {name}");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("1\tNetworking");
                Console.WriteLine("2\tSoftware");
                Console.WriteLine("3\tHardware");
                Console.WriteLine("4\tPhone/Tablet");
                Console.WriteLine("5\tUnsure");
                Console.WriteLine("0\tExit");
                Console.WriteLine("\n\n\n\n");
                Console.WriteLine("Please pick a number:");
                input = Convert.ToInt32(Console.ReadLine());

                Console.Clear();


                switch (input)
                {
                    case 1:
                        Networking();
                        break;
                    case 2:
                        Software();
                        break;
                    case 3:
                        Hardware();
                        break;
                    case 4:
                        Device();
                        break;
                    case 5:
                        Unsure();
                        break;
                    default:

                        break;
                }
            } while (input != 0);
            Console.ReadLine();
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


        static void Software()    //ANTIVIRUS one main question with its follow on questions attached
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
            Console.ReadLine();
        }

        public static string UserName()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            return name;
        }

        ////////////Seymours Zone\\\\\\\\\\\


        public static void Networking()
        {

            string answer = "0/";

            Console.WriteLine("Hello Is your Networking Issue Device Related Y or N");
            answer = answer.ToLower();


            if (answer.Contains("y"))
            {


                Console.WriteLine("Is The computer using wifi or network cable");





            }



            if (answer.Contains("n"))

            {

                string uInput;
                Console.WriteLine("Is you Modem Pluged in");

                Console.WriteLine("Yes:     1");
                Console.WriteLine("No       2");



                uInput = Console.ReadLine();
                uInput = uInput.ToLower();




                switch (uInput)
                {

                    case "1":
                        Console.WriteLine("Please Plug in The Modem");
                        break;



                    case "2":

                        Console.WriteLine("Are their any deviced wired directly to the modem");
                        Console.WriteLine("yes or no");
                        uInput = Console.ReadLine();
                        uInput = uInput.ToLower();


                        break;

                    case "yes":
                        Console.WriteLine("Please Unplug all the Devices conected and restart the modem");

                        break;



                    case "no":

                        Console.WriteLine("Are Their an cables pluged into the modem");
                        uInput = "1";




                        break;
                }
            }
            else
            {

                Main();
            }

            Console.ReadLine();
        }
        static void Unsure()
        {
            string answer, answer2, answer3;
            int choice;

            Console.WriteLine("Do you have a computer, phone or tablet that is not working correctly?");
            answer = Console.ReadLine();
            answer = answer.ToLower();

            if (answer.Contains("y"))
            {
                Console.WriteLine("Is the issue:");
                Console.WriteLine("1\tInvolving the interface of the device (such as to do with apps, settings, or functionality)?");
                Console.WriteLine("2\tInvolving the use of or connectivity of internet?");
                Console.WriteLine("3\tTo do with the physical aspect (such as blank screens, unresponsive keyboards or not functioning buttons?");
                Console.WriteLine("4\tNone of the above");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("It seems you have an ");
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    default:

                        break;
                }
            }
            Console.ReadLine();
        }
        //////////////////////Nabeel's zone\\\\\\\\\\\\\\\\\\\\\\\\\\\
        static void Hardware()
        {

            string answer, ans2, ans3, ans4, ans5, ans6, ans7, ans8, anss, anss1, anss2, anss3, anss4;
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
                Console.WriteLine("Is your desktop shutting off randomly? Y or N");
                ans3 = Console.ReadLine();
                ans3 = ans3.ToLower();
                if (ans3.Contains("y"))
                {
                    Console.WriteLine("Do you believe this is a RAM or cables issue? Or are you not sure??");
                    ans4 = Console.ReadLine();
                    ans4 = ans4.ToLower();

                    switch (ans4)
                    {
                        case "cable":
                        case "cables":
                            Console.WriteLine("Is the cable loose? If so try pushing in?");
                            break;
                        case "RAM":
                        case "ram":
                            Console.WriteLine("Are you sure your RAM is installed correctly?");
                            break;
                        default:
                            Console.WriteLine("Have you troubleshooted it for problems?");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Is your computer slow? Y or N");
                    ans5 = Console.ReadLine();
                    ans5 = ans5.ToLower();
                    if (ans5.Contains("y"))
                    {
                        Console.WriteLine("Do you believe this is related to having many programs running or you don't have anymore storage remianing? Or are you not sure");
                        ans6 = Console.ReadLine();
                        ans6 = ans6.ToLower();

                        switch (ans6)
                        {
                            case "slow":
                            case "freezing":
                                Console.WriteLine("Have you checked the Task Manger for your Memory usage? Y or N");
                                ans7 = Console.ReadLine();
                                ans7 = ans7.ToLower();
                                if (ans6.Contains("n"))
                                {
                                    Console.WriteLine("Have you check your avialable on storage on your device Y or N");
                                    ans8 = Console.ReadLine();
                                    ans8 = ans8.ToLower();
                                    Console.WriteLine("Have you deleted the temp files?");
                                }
                                break;
                        }
                    }
                    else
                    {
                        bool check = false;
                        Console.WriteLine("Do you believe the problems are happening outside the computer (such as cables), or inside the computer? Or are you not sure?");
                        anss = Console.ReadLine();
                        anss = anss.ToLower();

                        switch (anss)
                        {
                            case "cable":
                            case "cables":
                            case "outside":
                                Console.WriteLine("Have you tried unplugging and replugging-in your cables?");
                                anss1 = Console.ReadLine();
                                anss1 = anss1.ToLower();
                                if (anss1.Contains("y"))
                                {
                                    Console.WriteLine("Are you sure you are having hardware problems?");
                                    anss2 = Console.ReadLine();
                                    anss2 = anss2.ToLower();

                                    if (anss2.Contains("y"))
                                    {
                                        Console.WriteLine("Are you sure it is cable related?");
                                        anss3 = Console.ReadLine();
                                        anss3 = anss3.ToLower();
                                        if (anss3.Contains("y"))
                                        {
                                            Console.WriteLine("Have you ever had cable problems before?");
                                            anss4 = Console.ReadLine();
                                            anss4 = anss4.ToLower();

                                            if (anss4.Contains("y"))
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
                Console.ReadLine();
            }
        }




        //////////////////////Nabeel's zone\\\\\\\\\\\\\\\\\\\\\\\\\\\



        //////////////////////Bradley's zone\\\\\\\\\\\\\\\\\\\\\\\\\\\


        static void Device()   //Mobile devices and tablets
        {
            string answer, answer2, answer3, answer4;
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
                    Console.WriteLine("How old is your product?");
                    answer4 = Console.ReadLine();
                    answer4.ToLower();





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
                if (answer3 == "android")
                {

                }

            }
            else
            {
                Console.WriteLine("");
                //call for switch
            }
            Console.ReadLine();
        }
    }
}