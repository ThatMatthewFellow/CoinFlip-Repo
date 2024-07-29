using System;
// Coin flipper - ThatMatthewFellow
namespace CoinFlip{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("\"Here's a coin flipper!\"");
            Random random = new Random();
            // To quit
            int quit = -1;
             // Question
            Console.WriteLine("Flip a coin (y/n)? ");
            String answer = "";
            // Check if answer is y or n
            bool ca = false;
            while(ca != true){
                // Input
                Console.Write("Enter your choice: ");
                answer = Console.ReadLine();
                if(answer == "y" || answer == "n"){
                    ca = true;
                }
                else{
                    Console.WriteLine("Invalid input!");
                }
            }
            // Main loop
            while(quit != 1){
                // Generate a number between 1 and 100
                int rNum = random.Next(1,1000000);
                // Algorithm to flip coin
                // For heads
                if(answer == "y" && rNum <= 500000)
                    Console.WriteLine("Heads");
                // For tails
                else if(answer == "y" && rNum > 500000)
                    Console.WriteLine("Tails");      
                else{
                    Console.WriteLine("Coin not flipped!");
                }
                // Only ask if they want to go again if they originally wanted to flip a coin
                if(answer != "n"){          
                    // Try again?
                    Console.WriteLine("Would you like to flip another? (y/n)");
                    String choice = "";
                    bool c2 = false;
                    // Check for if the choice is valid
                    while(c2 != true){
                        // Input
                        Console.Write("Enter your choice: ");
                        choice = Console.ReadLine();
                        if(choice == "y" || choice == "n"){
                            c2 = true;
                        }
                        else{
                            Console.WriteLine("Invalid input!");
                        }
                    }
                    // Set answer to y just in case
                    // End or keep going
                    if(choice == "n"){
                        quit = 1;
                        Console.WriteLine("Ending program");
                    }
                    else{
                        quit = 0;
                    }
                }
                // End the program
                else{
                    quit = 1;
                    Console.WriteLine("Ending program");
                }
            }
        }
    }
}