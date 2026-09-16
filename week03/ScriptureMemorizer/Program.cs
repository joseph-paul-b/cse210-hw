using System;

class Program
{
    static void Main(string[] args)
    {
        // Creativity and exceeding requirements:
        // The program shows memorization progress by displaying
        // how many words have been hidden out of the total number of words.
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding.";

        Scripture scripture = new Scripture(reference, text);

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine(
            $"Progress: {scripture.GetHiddenWordCount()} of {scripture.GetTotalWordCount()} words hidden.");

        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine();
            Console.Write("Press Enter to hide words or type 'quit' to finish: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);

            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine(
                $"Progress: {scripture.GetHiddenWordCount()} of {scripture.GetTotalWordCount()} words hidden.");
        }
    }
}