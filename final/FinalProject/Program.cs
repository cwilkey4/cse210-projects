// Celestia Wilkey
// Date: 03/28/2023 || ⓒ copyright all rights reserved, BYU-I CSE 210
// This is part of the Final Project

using System;

namespace FinalProject
{
class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Movie movie = new Movie();
            AudioBook audiobook = new AudioBook();
            Check checkout = new Check();
            CheckIn checkin = new CheckIn();
            Extension extension = new Extension();

            string cwlibraryCard = "card.txt";
            string cwmenuChoice = "00";
            double cwfee = 00;
            double cwlateFee = 0;
            string cwwrittenLateFee = cwlateFee.ToString("F");
            string cwwrittenFee = cwfee.ToString("F");

            while (cwmenuChoice != "5") {
                Console.WriteLine("Welcome to the library!");
                Console.WriteLine("What would you like to do? ");
                Console.WriteLine("1. Check out items");
                Console.WriteLine("2. Return items");
                Console.WriteLine("3. Extend due date");
                Console.WriteLine("4. Pay fee");
                Console.WriteLine("5. Quit");

                cwmenuChoice = Console.ReadLine();

                    if (cwmenuChoice == "1") 
                    {
                        Console.WriteLine("What do you want to check out?");
                        Console.WriteLine("1. Book");
                        Console.WriteLine("2. Audiobook");
                        Console.WriteLine("3. Movie");
                        
                        bool cwrepeat = true;
                        string cwnewItem = "";

                        DateOnly cwdueDate = checkout.GiveDueDate();

                        string cwwrittenDueDate = cwdueDate.ToString();

                        while (cwrepeat == true)
                        {
                            string cwitem = Console.ReadLine();
                            if (cwitem == "1") {
                                cwrepeat = false;
                                cwnewItem = "book";

                                Console.WriteLine("What is the title? ");
                                string cwtitle = Console.ReadLine();

                                Console.WriteLine("What is the author's name? ");
                                string cwauthor = Console.ReadLine();

                                Console.WriteLine("What genre is it? ");
                                string cwgenre = Console.ReadLine();

                                book.SetDetails(cwtitle, cwauthor, cwgenre);
                                string cwitemDetails = book.GetDetails();

                                Console.WriteLine($"Your {cwnewItem} will be due on {cwwrittenDueDate}");

                                using (StreamWriter outputFile = new StreamWriter(cwlibraryCard, true))
                                {                                
                                    outputFile.WriteLine($"{cwitemDetails}|{cwwrittenDueDate}");
                                    outputFile.Close();
                                }
                            }
                            else if (cwitem == "2") {
                                cwrepeat = false;
                                cwnewItem = "audiobook";  

                                Console.WriteLine("What is the title?");
                                string cwtitle = Console.ReadLine();

                                Console.WriteLine("What is the author's name? ");
                                string cwauthor = Console.ReadLine();
                                
                                Console.WriteLine("Who narrates it? ");
                                string cwnarrator = Console.ReadLine();

                                Console.WriteLine("What genre is it? ");
                                string cwgenre = Console.ReadLine();  

                                audiobook.SetDetails(cwtitle, cwauthor, cwnarrator, cwgenre); 
                                string cwitemDetails = audiobook.GetDetails();    

                                Console.WriteLine($"Your {cwnewItem} will be due on {cwwrittenDueDate}");

                                using (StreamWriter outputFile = new StreamWriter(cwlibraryCard, true))
                                {                                
                                    outputFile.WriteLine($"{cwitemDetails}|{cwwrittenDueDate}");

                                    outputFile.Close();
                                } 
                            }
                            else if (cwitem == "3") {
                                cwrepeat = false;
                                cwnewItem = "movie";  

                                Console.WriteLine("What is the movie called? ");
                                string cwtitle = Console.ReadLine();

                                Console.WriteLine("What is the director's name? ");
                                string cwdirector = Console.ReadLine();

                                Console.WriteLine("What studio made this movie? ");
                                string cwstudio = Console.ReadLine();

                                Console.WriteLine("What genre is it? ");
                                string cwgenre = Console.ReadLine();    

                                Console.WriteLine("What is the rating? ");
                                string cwrating = Console.ReadLine();

                                movie.SetDetails(cwtitle, cwdirector, cwstudio, cwrating, cwgenre);
                                string cwitemDetails = movie.GetDetails();

                                Console.WriteLine($"Your {cwnewItem} will be due on {cwwrittenDueDate}");

                                using (StreamWriter outputFile = new StreamWriter(cwlibraryCard, true))
                                {                            
                                    outputFile.WriteLine($"{cwitemDetails}|{cwwrittenDueDate}");
                                    outputFile.Close();
                                }
                            }
                            else {
                                System.Console.WriteLine("Please enter a number from 1 to 3.");
                                cwrepeat = true;
                            }
                        }

                    }

                    else if (cwmenuChoice == "2") 
                    {
                        string[] items = System.IO.File.ReadAllLines(cwlibraryCard);
                        int cwcount = 0;
                        int cwarrayTotal;

                        Console.WriteLine(" ");

                        foreach (string item in items)
                        {
                            cwcount = cwcount + 1;

                            string cwli = $"{cwcount.ToString()}. ";

                            Console.Write(cwli + item);
                            Console.WriteLine(" ");
                        }

                        cwarrayTotal = items.Length;

                        Console.WriteLine(" ");
                        Console.WriteLine("Which item are you returning? (Please pick a number) ");
                        Console.WriteLine("(Enter 0 to quit)");
                        string cwuserReturn = Console.ReadLine();

                        while (cwuserReturn != "0")
                        {
                            int cwitemReturn = int.Parse(cwuserReturn);
                            cwitemReturn = cwitemReturn - 1;

                            if (cwitemReturn <= cwarrayTotal)
                            {
                                try 
                                {
                                    // Here is the item. Will need to make sure that the user selects a proper choice.
                                    string itemReturned = items[cwitemReturn];

                                    string[] details = itemReturned.Split("|");
                                    string cwdateDue = details[1];
                                    DateTime cwdueDate = DateTime.Parse(cwdateDue);

                                    cwlateFee = checkin.CheckFee(cwdueDate);
                                    cwfee = cwfee + cwlateFee;
                                    
                                    if (cwfee > 0 )
                                    {
                                        cwwrittenFee = cwfee.ToString("F");
                                        cwwrittenLateFee = cwlateFee.ToString("F");
                                        Console.WriteLine($"You returned {itemReturned}. There is a ${cwwrittenLateFee} late fee on it. You have a ${cwwrittenFee} charge on your card.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Thank you!");
                                    }     
                                    
                                    Console.WriteLine(" ");                           

                                    // Creating a new array to replace the old one.
                                    string[] cwitemsKept = new string[items.Length - 1];

                                    Array.Copy(items, 0, cwitemsKept, 0, cwitemReturn);
                                    Array.Copy(items, cwitemReturn + 1, cwitemsKept, cwitemReturn, items.Length - cwitemReturn - 1);

                                    items = cwitemsKept;
                                    cwarrayTotal = items.Length;

                                    using (StreamWriter outputFile = new StreamWriter(cwlibraryCard, false))
                                    {     
                                        foreach (string item in items)
                                        {
                                            outputFile.Write(item);
                                            outputFile.WriteLine(" ");
                                        }                       
                            
                                        outputFile.Close();
                                    }

                                    cwcount = 0;

                                    foreach (string item in items)
                                    {
                                        cwcount = cwcount + 1;

                                        string cwli = $"{cwcount.ToString()}. ";

                                        Console.Write(cwli + item);
                                        Console.WriteLine(" ");
                                    }

                                    Console.WriteLine("Would you like to return something else? ");
                                    Console.WriteLine("(Enter 0 to quit)");
                                    cwuserReturn = Console.ReadLine();
                                }
                                catch
                                {
                                    Console.WriteLine("Please select a valid option.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid number!");
                                cwuserReturn = Console.ReadLine();
                            }
                        }
                    }

                    else if (cwmenuChoice == "3") 
                    {
                        string[] items = System.IO.File.ReadAllLines(cwlibraryCard);
                        int cwcount = 0;
                        int cwarrayTotal;

                        Console.WriteLine(" ");
                        Console.WriteLine("Here is a list of your current items:");

                        foreach (string item in items)
                        {
                            cwcount = cwcount + 1;

                            string cwli = $"{cwcount.ToString()}. ";

                            Console.Write(cwli + item);
                            Console.WriteLine(" ");
                        }
                        Console.WriteLine(" ");
                        Console.WriteLine("Which item would you like to extend? ");
                        Console.WriteLine("(Enter 0 to quit)");
                        string cwuserExtend = Console.ReadLine();

                        cwarrayTotal = items.Length;

                        while (cwuserExtend != "0")
                        {
                            int cwitemExtend = int.Parse(cwuserExtend);
                            cwitemExtend = cwitemExtend - 1;

                            Console.WriteLine("You can request and extension up to two months. When do you want your items due?");
                            Console.Write("What year do you want it due? (yyyy) ");
                            string cwyear = Console.ReadLine();
                            Console.Write("Month? (mm) ");
                            string cwmonth = Console.ReadLine();
                            Console.Write("Day? (dd) ");
                            string cwday = Console.ReadLine();

                            string cwextension = $"{cwyear}, {cwmonth}, {cwday}";

                            try
                            {
                                DateTime cwextendedDate = DateTime.Parse(cwextension);
                                DateOnly cwextendedDateOnly = DateOnly.Parse(cwextension);


                                bool cwtoDo = extension.CheckExtension(cwextendedDate);
                                string cwmessage = extension.GiveMessage(cwextendedDate);

                                if (cwitemExtend <= cwarrayTotal)
                                {

                                    if (cwtoDo == true)
                                    {
                                        Console.WriteLine($"Fantastic! It will be due on {cwextension}.");

                                        string itemExtended = items[cwitemExtend];
                                        string[] details = itemExtended.Split("|");
                                        string cwitemInfo = details[0];
                                        string cwdateDue = details[1];

                                        string cwextendedItem = extension.AssignDueDate(cwitemInfo, cwextendedDateOnly);
                                        
                                        Console.WriteLine(" ");                           

                                        // Part 1
                                        string[] cwitemsKept = new string[items.Length - 1];

                                        Array.Copy(items, 0, cwitemsKept, 0, cwitemExtend);
                                        Array.Copy(items, cwitemExtend + 1, cwitemsKept, cwitemExtend, items.Length - cwitemExtend - 1);

                                        // Part 2
                                        Array.Resize(ref cwitemsKept, cwitemsKept.Length + 1);
                                        cwitemsKept[cwitemsKept.Length - 1] = cwextendedItem;

                                        items = cwitemsKept;
                                        cwarrayTotal = items.Length;

                                        using (StreamWriter outputFile = new StreamWriter(cwlibraryCard, false))
                                        {     
                                            foreach (string item in items)
                                            {
                                                outputFile.Write(item);
                                                outputFile.WriteLine(" ");
                                            }                   

                                            outputFile.Close();
                                        }

                                        cwcount = 0;

                                        foreach (string item in items)
                                        {
                                            cwcount = cwcount + 1;

                                            string cwli = $"{cwcount.ToString()}. ";

                                            Console.Write(cwli + item);
                                            Console.WriteLine(" ");
                                        }

                                        cwuserExtend = "0";
                                    }
                                    else 
                                    {
                                        Console.WriteLine(cwmessage);
                                    }
                                    
                                }
                                else
                                {
                                    Console.WriteLine("Please enter a valid number!");
                                }
                            }
                            catch
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine("Please enter a valid date. (yyyy/mm/dd)");
                                cwuserExtend = "0";
                            }
                        }
                    }

                    else if (cwmenuChoice == "4") 
                    {
                        if (cwfee > 0)
                        {
                            string cwuserPay = "hi";

                            while (cwuserPay != "0")
                            {
                                Console.WriteLine($"You have a {cwwrittenFee} charge on your card. How much would you like to pay? (0 to cancel)");
                                cwuserPay = Console.ReadLine();

                                try
                                {
                                    double cwpayment = double.Parse(cwuserPay);
                                    double cwtotal = cwfee - cwpayment;

                                    if (cwpayment > 0)
                                    {
                                        double cwchange;
                                        if (cwtotal < 0)
                                        {
                                            cwfee = 0;
                                            cwwrittenFee = cwfee.ToString("F");
                                            cwchange = -(cwtotal);

                                            string cwchangeWritten = cwchange.ToString("F");

                                            Console.WriteLine($"Thank you for paying! ${cwchangeWritten} is your change.");
                                        }
                                        else if (cwtotal > 0)
                                        {
                                            cwfee = cwtotal;
                                            cwwrittenFee = cwfee.ToString("F");
                                            Console.WriteLine($"Thank you for paying! There is now a {cwwrittenFee} charge left on your card.");
                                            Console.WriteLine("Press enter to continue");
                                            Console.ReadLine();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Thanks for paying! There are no outstanding charges on your card. (Press Enter to continue)");
                                            Console.ReadLine();
                                            cwuserPay = "0";
                                        }
                                        Console.WriteLine(" ");
                                    }
                                    else if (cwpayment < 0)
                                    {
                                        Console.WriteLine("Please enter a postive number.");
                                    }


                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Please enter with only digits and a decimal if necessary. (Example: 1.00)");
                                    Console.WriteLine("Alternatively, enter 0 to cancel.");;
                                }
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("You have no charges on your card. You're good to go! (Press enter to continue)");
                            Console.ReadLine();
                            Console.WriteLine(" ");
                        }
                    }
            }
        }
    }
}