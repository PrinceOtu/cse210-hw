using System;

public class Program
{
    public static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter your choice:");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string[] prompts = {
                        "Who was the most interesting person I interacted with today?",
                        "What was the best part of my day?",
                        "How did I see the hand of the Lord in my life today?",
                        "What was the strongest emotion I felt today?",
                        "If I had one thing I could do over today, what would it be?"
                    };
                    Random random = new Random();
                    string prompt = prompts[random.Next(prompts.Length)];
                    Console.WriteLine(prompt);

                    string response = Console.ReadLine();
                    JournalEntry entry = new JournalEntry(DateTime.Now.ToString(), prompt, response); // Error: Missing 'using System;'
                    journal.AddEntry(entry); // Error: NullReferenceException due to uninitialized list
                    break;

                case "2":
                    journal.DisplayEntries(); // Error: might throw an exception if list is uninitialized
                    break;

                case "3":
                    Console.WriteLine("Enter a filename:");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename); // Error: Missing 'using System.IO;'
                    break;

                case "4":
                    Console.WriteLine("Enter a filename:");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename); // Error: Missing 'using System.IO;'
                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice, please try again."); // Error: misspelled words might occur in messages
                    break;
            }
        }
    }
}