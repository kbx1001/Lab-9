using System;

namespace Lab_9
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] name = { "Christian", "Andrea", "Chance" };
            string[] food = { "Pizza", "Tacos", "Chicken Alfredo" };
            string[] homeTown = { "Los Angeles", "San Diego", "Grand Blanc" };

            string userChoice;
            bool loop = true;
            int userNumber = 0;

            Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about? (enter a number 0-2)");
            userChoice = Console.ReadLine();

            while (loop)
            {
                try
                {
                    userNumber = int.Parse(userChoice);
                    Console.WriteLine($"You picked: {name[userNumber]}");
                    loop = false;
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                    userChoice = Console.ReadLine();
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    userChoice = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    userChoice = Console.ReadLine();
                }
            }

            Console.WriteLine("You picked " + name[userNumber] + " what would you like to know about " + name[userNumber] + "? (enter hometown or favorite food): ");
            userChoice = Console.ReadLine();

            while (userChoice.ToLower() != "hometown" && userChoice.ToLower() != "favorite food")
            {
                Console.WriteLine("That data does not exist. Please try again. (enter hometown or favorite food): ");
                userChoice = Console.ReadLine();
            }

            if (userChoice.ToLower() == "hometown")
            {
                Console.WriteLine(name[userNumber] + "'s hometown is " + homeTown[userNumber] + ". Would you like to know more? (y/n)");
                userChoice = Console.ReadLine();

                while (userChoice.ToLower() != "y" && userChoice.ToLower() != "n")
                {
                    Console.WriteLine("That is invalid does not exist. Please try again. (enter y or n): ");
                    userChoice = Console.ReadLine();
                }
                if (userChoice.ToLower() == "y")
                {
                    Console.WriteLine(name[userNumber] + "'s favotite food is " + food[userNumber] + ".");
                    Console.Write("Thank you for playing!");
                }
                else
                {
                    Console.WriteLine("Thank you!");
                }
            }
            else
            {
                Console.WriteLine(name[userNumber] + "'s favotite food is " + food[userNumber] + ". Would you like to know more? (y/n)");
                userChoice = Console.ReadLine();

                while (userChoice.ToLower() != "y" && userChoice.ToLower() != "n")
                {
                    Console.WriteLine("That is invalid does not exist. Please try again. (enter y or n): ");
                    userChoice = Console.ReadLine();
                }
                if (userChoice.ToLower() == "y")
                {
                    Console.WriteLine(name[userNumber] + "'s hometown is " + homeTown[userNumber] + ".");
                    Console.Write("Thank you for playing!");
                }
                else
                {
                    Console.WriteLine("Thank you!");
                }
            }
        }
    }
}
