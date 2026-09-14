using System;

class Program
{
    static void Main(string[] args)
    {
        // Creativity and exceeding requirements:
        // In addition to the required date, prompt, and response,
        // this program records the user's mood for each journal entry.
        // The mood is also saved to and loaded from the journal file.

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.WriteLine("Welcome to the Journal Program!");

        bool running = true;

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal");
            Console.WriteLine("4. Load the journal");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Response: ");
                string response = Console.ReadLine();

                Console.Write("How would you describe your mood today? ");
                string mood = Console.ReadLine();

                string date = DateTime.Now.ToShortDateString();

                Entry entry = new Entry(date, prompt, response, mood);
                journal.AddEntry(entry);

                Console.WriteLine("Your entry has been added.");
            }
            else if (choice == "2")
            {
                journal.Display();
            }
            else if (choice == "3")
            {
                Console.Write("Enter the filename to save to: ");
                string filename = Console.ReadLine();

                journal.SaveToFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("Enter the filename to load from: ");
                string filename = Console.ReadLine();

                journal.LoadFromFile(filename);
            }
            else if (choice == "5")
            {
                running = false;
                Console.WriteLine("Thank you for using the Journal Program. Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a number from 1 to 5.");
            }
        }
    }
}