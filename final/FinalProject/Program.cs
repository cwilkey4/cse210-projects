using System;

namespace FinalProject
{
class Program
    {
        static void Main(string[] args)
        {
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

                    if (cwmenuChoice == "1") {
                        Console.WriteLine("What do you want to check out?");
                        Console.WriteLine("1. Book");
                        Console.WriteLine("2. Audiobook");
                        Console.WriteLine("3. Movie");
                        
                        bool cwrepeat = true;

                        while (cwrepeat == true)
                        {
                            string cwitem = Console.ReadLine();
                            if (cwitem == "1") {
                                cwrepeat = false;
                                Console.WriteLine("Book");
                            }
                            else if (cwitem == "2") {
                                cwrepeat = false;
                                Console.WriteLine("Audiobook");
                            }
                            else if (cwitem == "3") {
                                cwrepeat = false;
                                Console.WriteLine("Movie");
                            }
                            else {
                                System.Console.WriteLine("Please enter a number from 1 to 3.");
                                cwrepeat = true;
                            }
                        }
                    }

                    else if (cwmenuChoice == "2") {
                        Console.WriteLine("Which item are you returning?");
                        
                        // Display numbered list

                        // Have the user select a number

                        // Remove the item from the file. Run it through "CheckIn.cs" to get a fee, if any.

                        // If the fee is more than $0.00, alert the patron.
                    }

                    else if (cwmenuChoice == "3") {
                        Console.WriteLine("You can request and extension up to two months. When do you want your items due?");

                        // DateTime cwextention = 
                    }

                    else if (cwmenuChoice == "4") {
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