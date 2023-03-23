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


            string cwlibraryCard = "card.txt";
            string cwmenuChoice = "00";
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

                        while (cwrepeat == true)
                        {
                            string cwitem = Console.ReadLine();
                            if (cwitem == "1") {
                                cwrepeat = false;
                                cwnewItem = "Book";

                                Console.WriteLine("What is the title? ");
                                string cwtitle = Console.ReadLine();

                                Console.WriteLine("What is the author's name? ");
                                string cwauthor = Console.ReadLine();

                                Console.WriteLine("What genre is it? ");
                                string cwgenre = Console.ReadLine();
                            }
                            else if (cwitem == "2") {
                                cwrepeat = false;
                                cwnewItem = "Audiobook";          
                            }
                            else if (cwitem == "3") {
                                cwrepeat = false;
                                cwnewItem = "Movie";                 
                            }
                            else {
                                System.Console.WriteLine("Please enter a number from 1 to 3.");
                                cwrepeat = true;
                            }
                        }

                        using (StreamWriter outputFile = new StreamWriter(cwlibraryCard))
                        {
                            // outputFile.WriteLine($"{cwname}'s Library Card.");
                            
                            outputFile.WriteLine($"You checked out a {cwnewItem}.");
                        }
                    }

                    else if (cwmenuChoice == "2") 
                    {
                        Console.WriteLine("Which item are you returning?");
                        
                        // Call CheckIn.cs:
                        // string[] items = System.IO.File.ReadAllLines(cwlibraryCard);

                        // foreach (string item in items)
                        // {
                        //     string[] details = item.Split("|");

                        //     string cwtitle = details[0];
                        //     string cwdetails = details[1];
                        //     DateTime cwdueDate = details[2];
                        // }
                        
                        // Display numbered list
                        string[] items = System.IO.File.ReadAllLines(cwlibraryCard);

                        foreach (string item in items) 
                        {
                            // May want to break it down a little further.
                            Console.WriteLine(item);
                            Console.WriteLine(" ");
                        }

                        // Have the user select a number (Min-Max limited to the number of items there are.)
                        // removedItem = removedItem - 1;

                        // Assign this item to a variable.

                        // Remove the item from the file. Run it through "CheckIn.cs" to get a fee, if any.

                        // If the fee is more than $0.00, alert the patron.
                    }

                    else if (cwmenuChoice == "3") 
                    {
                        Console.WriteLine("You can request and extension up to two months. When do you want your items due?");
                        // DateOnly
                        // DateTime cwextention = 
                    }

                    else if (cwmenuChoice == "4") 
                    {
                        // Get a fee from CheckIn. Make a variable for the fee and inform the user of their fee.
                        Console.WriteLine("How much would you like to pay?");

                        string cwuserpayment = Console.ReadLine();
                        int cwpayment = int.Parse(cwuserpayment);

                        // Either make a function or make a class that does the math.

                        // If the payment is higher than the fee, give change.
                        // If the payment is equal to or less than the fee, thank them and tell them what their remaining balance is.
                    }


            }
        }
    }
}