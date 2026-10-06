using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
                breathingCount++;
            }
            else if (choice == "2")
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.Run();
                reflectingCount++;
            }
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
                listingCount++;
            }
            else if (choice == "4")
            {
                Console.WriteLine();
                Console.WriteLine("Thank you for using the Mindfulness Program.");
                Console.WriteLine();
                Console.WriteLine("Session Summary:");
                Console.WriteLine($"Breathing activities: {breathingCount}");
                Console.WriteLine($"Reflecting activities: {reflectingCount}");
                Console.WriteLine($"Listing activities: {listingCount}");
                Console.WriteLine();
            }
        }
    }
}