using System;
using System.Threading;

namespace Project
{
    class Project1
    {
        public static string name;
        public static int count = 0;
        static void Main()                                      //everytime you call for a main insert a Console.WriteLine statement and
        {                                                       //a Thread.Sleep(2000); or Thread.Sleep(2500); or Thread.Sleep(3000);
            int input;

            //while (count != 1)
            //{
            //    UserName();
            //    count++;
            //}
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
                        Console.WriteLine($"Thank you, {name}");
                        Thread.Sleep(1500);
                        Environment.Exit(-1);
                        break;
                }
            } 
            Console.ReadLine();
        }

        //////////////////////Casssidy's zone\\\\\\\\\\\\\\\\\\\\\\\\\\\


        static void Software()    
        {
            string answer, answer2, answer3, answer4, browser;
            Console.WriteLine("Do you have antivirus software installed on your computer?");
            answer = Console.ReadLine();
            answer.ToLower();
            if (answer.Contains("y"))
            {
                Console.WriteLine("Does your antivirus software regularly scan for viruses?");
                answer2 = Console.ReadLine();
                answer2.ToLower();
                if (answer2.Contains("y"))
                {
                    Console.WriteLine("Do you believe that your computer has Malware?");
                    answer4 = Console.ReadLine();
                    answer4.ToLower();

                    if (answer4.Contains("y"))
                    {
                        Console.WriteLine("Please get your antivirus software to do a full computer scan and eliminate all threats");
                        Thread.Sleep(2500);
                        Main();
                    }
                    else
                    {
                        Console.WriteLine("What browser do you use?");
                        browser = Console.ReadLine();
                        Console.WriteLine($"Have you had problems with {browser} before?");
                        answer4 = Console.ReadLine();
                        answer4.ToLower();

                        if (answer4.Contains("y"))
                        {
                            Console.WriteLine("Try using a different broswer and see if that helps.");
                            Thread.Sleep(2500);
                            Main();
                        }
                        else
                        {
                            Console.WriteLine("Do you believe this issue may involve the internet?");
                            answer4 = Console.ReadLine();
                            answer4.ToLower();

                            if (answer4.Contains("y"))
                            {
                                Console.WriteLine("I am returning you to the menu, it seems this issue is networking related. Please press 1");
                                Thread.Sleep(3000);
                                Main();
                            }
                            else
                            {
                                Console.WriteLine("Try doing a complete shutdown of your computer.");
                                Thread.Sleep(2500);
                                Main();
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Do you know how to set your software up to regularly scan?");
                    answer3 = Console.ReadLine();
                    answer3.ToLower();
                    if (answer3.Contains("y"))
                    {
                        Console.WriteLine("It is important that your antivirus software runs scans regularly.");
                        Thread.Sleep(2500);
                        Main();
                    }
                    else
                    {
                        Console.WriteLine("It is important that your antivirus software runs scans, please consult the preferred softwares manual to learn how to schedule scans.");
                        Thread.Sleep(3000);
                        Main();
                    }
                }
            }
            else
            {
                Console.WriteLine($"It is important to install an antivirus software on your computer, {name}.");
                Thread.Sleep(2500);
                Main();
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
            answer = Console.ReadLine();
            answer = answer.ToLower();


            if (answer.Contains("y"))
            {
                Console.WriteLine("Is The computer using wifi or network cable");
                string uInput;
                uInput = Console.ReadLine();
                uInput = uInput.ToLower();

                switch (uInput)
                {

                    case "wifi":
                        Console.Clear();
                        Console.WriteLine("Please Reboot Modem");
                        Thread.Sleep(2000);
                        Main();
                        break;





                    case "cable":
                        Console.Clear();
                        Console.WriteLine("Please check cable and try another ");
                        Thread.Sleep(2000);
                        Main();

                        break;
                       

                }








            }



            if (answer.Contains("n"))

            {

                string uInput;
                Console.WriteLine("Is you Modem Pluged in");
                Console.WriteLine("Yes");
                Console.WriteLine("No");

                uInput = Console.ReadLine();
                uInput = uInput.ToLower();




                switch (uInput)
                {

                    case "no":
                        Console.Clear();
                        Console.WriteLine("Please Plug in The Modem");
                        Thread.Sleep(2000);
                        Main();
                        break;



                    case "yes":
                        Console.Clear();
                        Console.WriteLine("Are their any deviced wired directly to the modem");
                        Console.WriteLine("y or n");
                        uInput = Console.ReadLine();
                        uInput = uInput.ToLower();
                      
                        
                        if (uInput.Contains("y"))

                        {
                            Console.Clear();
                            Console.WriteLine("Please unplug all devices excpet you device" );
                            Thread.Sleep(2000);
                            Main();
                        }

                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Please restart the modem");
                            Thread.Sleep(2000);
                            Main();
                        }
                        break;
                }
              
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
                        Console.WriteLine("It seems you have a software issue. I am transferring you back to the menu. Please press 2");
                        Thread.Sleep(1500);
                        Main();
                        break;
                    case 2:
                        Console.WriteLine("It seems you have a networking issue. I am transferring you back to the menu. Please press 1");
                        Thread.Sleep(1500);
                        Main();
                        break;
                    case 3:
                        Console.WriteLine("It seems you have a hardware issue. I am transferring you back to the menu. Please press 3");
                        Thread.Sleep(1500);
                        Main();
                        break;
                    default:
                        Console.WriteLine("Is this issue to do with your phone/tablet?");
                        answer2 = Console.ReadLine();
                        answer2 = answer2.ToLower();

                        if (answer2.Contains("y"))
                        {
                            Console.WriteLine("It seems you have a phone/tablet related issue. I am transferring you back to the menu. Please press 4");
                            Thread.Sleep(1500);
                            Main();
                        }
                        else
                        {
                            Console.WriteLine("Are you sure that you have a problem?");
                            answer3 = Console.ReadLine();
                            answer3 = answer3.ToLower();

                            if (answer3.Contains("y"))
                            {
                                Console.WriteLine("Try turning it off and on again.");
                                Thread.Sleep(2500);
                                Main();
                            }
                            else
                            {
                                Console.WriteLine($"Woah, {name}. Last time I asked you that question you gave me a different answer. I am going to transfer you back to the menu, please rethink your life choices.");
                                Thread.Sleep(3500);
                                Main();
                            }
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("Are you sure that you have a problem?");
                answer3 = Console.ReadLine();
                answer3 = answer3.ToLower();

                if (answer3.Contains("y"))
                {
                    Console.WriteLine("Try turning it off and on again.");
                    Thread.Sleep(2500);
                    Main();
                }
                else
                {
                    Console.WriteLine($"Woah, {name}. Last time I asked you that question you gave me a different answer. I am going to transfer you back to the menu, please rethink your life choices.");
                    Thread.Sleep(3500);
                    Main();
                }
            }
            Console.ReadLine();
        }
        //////////////////////Nabeel's zone\\\\\\\\\\\\\\\\\\\\\\\\\\\
        static void Hardware()
        {

            string answer, ans2, ans3, ans4, ans5, ans6, ans7, ans8, anss, anss1, anss2, anss3, anss4;
            Console.WriteLine("Are you facing a Monitor issue?");
            answer = Console.ReadLine();
            answer = answer.ToLower();

            if (answer.Contains("y"))
            {
                Console.WriteLine("Do you believe this problem is related to something such as cables? Or are you not sure?");
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
                        Console.WriteLine("Is your device connected properly?");
                        break;

                }
            }
            else
            {
                Console.WriteLine("Is your desktop shutting off randomly?");
                ans3 = Console.ReadLine();
                ans3 = ans3.ToLower();
                if (ans3.Contains("y"))
                {
                    Console.WriteLine("Do you believe this is a RAM or cable issue? Or are you not sure?");
                    ans4 = Console.ReadLine();
                    ans4 = ans4.ToLower();

                    switch (ans4)
                    {
                        case "cable":
                        case "cables":
                            Console.WriteLine("Your cables may be loose. Try plugging them in again.");
                            Thread.Sleep(2500);
                            Main();
                            break;
                        case "RAM":
                        case "ram":
                            Console.WriteLine("Please check to make sure that your RAM is installed correctly.");
                            Thread.Sleep(2500);
                            Main();
                            break;
                        default:
                            Console.WriteLine("Please troubleshoot your device");
                            Thread.Sleep(2500);
                            Main();
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
                                Console.WriteLine("Have you checked the Task Manger for your Memory usage?");
                                ans7 = Console.ReadLine();
                                ans7 = ans7.ToLower();
                                if (ans6.Contains("n"))
                                {
                                    Console.WriteLine("Have you check your avialable on storage on your device?");
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
                                                Thread.Sleep(2000);
                                                Main();
                                            }
                                            else
                                            {
                                                Console.WriteLine("Make sure all cables are placed into the correct slot");
                                                Thread.Sleep(2000);
                                                Main();
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Make sure all cables are placed into the correct slot");
                                            Thread.Sleep(2000);
                                            Main();
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
                                    Thread.Sleep(2000);
                                    Main();
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
                            Thread.Sleep(2000);
                            Main();
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