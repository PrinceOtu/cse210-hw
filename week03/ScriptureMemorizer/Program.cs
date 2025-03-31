using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize a scripture with reference and text
        Reference reference = new Reference("Proverbs", "3:5-6");
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart and lean not unto thine own understanding");

        while (true)
        {
            // Clear the console and display the scripture
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            // Check if all words are hidden
            if (scripture.AreAllWordsHidden())
            {
                Console.WriteLine("\nAll words are hidden. Program will end.");
                break;
            }

            // Prompt user to continue or quit
            Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input?.ToLower() == "quit")
            {
                Console.WriteLine("Exiting the program. Goodbye!");
                break;
            }

            // Hide random words in the scripture
            scripture.HideRandomWords();
        }
    }
}