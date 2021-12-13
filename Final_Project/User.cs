using System;
namespace Final_Project
{
    public static class User
    {
        public static void CommandLine()
        {
            Console.WriteLine("Welcome to the Plant Database");
            while (true) {
                Console.WriteLine("Please enter your plant id or search term (Q to quit): ");
                string userInput = Console.ReadLine();
                if (userInput == "Q") {
                    Console.WriteLine("Goodbye for now!");
                    break;
                }
                else if (userInput.Length != 0){
                    Input.Parse(userInput);
                }
            }
        }
    }
}
