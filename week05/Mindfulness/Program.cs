using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessApp
{
    abstract class Activity
    {
        protected string Name { get; set; }
        protected string Description { get; set; }
        protected int Duration { get; set; }

        public void Start()
        {
            Console.Clear();
            Console.WriteLine($"Activity: {Name}\n");
            Console.WriteLine(Description);
            Duration = GetDuration();
            Console.WriteLine("\nPrepare to begin...");
            ShowAnimation(3);

            Execute();

            Console.WriteLine("\nWell done! You have completed the activity.");
            Console.WriteLine($"Activity: {Name}, Duration: {Duration} seconds");
            ShowAnimation(3);
        }

        protected abstract void Execute();

        private int GetDuration()
        {
            int duration;
            while (true)
            {
                Console.Write("\nEnter duration (in seconds): ");
                if (int.TryParse(Console.ReadLine(), out duration) && duration > 0)
                {
                    return duration;
                }
                Console.WriteLine("Please enter a valid positive number.");
            }
        }

        protected void ShowAnimation(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }
    }

    class BreathingActivity : Activity
    {
        public BreathingActivity()
        {
            Name = "Breathing Exercise";
            Description = "This activity helps you relax by guiding you through slow breathing. Clear your mind and focus on your breath.";
        }

        protected override void Execute()
        {
            int cycles = Duration / 6; // Assuming 3 seconds per inhale/exhale
            for (int i = 0; i < cycles; i++)
            {
                Console.WriteLine("\nBreathe in...");
                ShowAnimation(3);
                Console.WriteLine("Breathe out...");
                ShowAnimation(3);
            }
        }
    }

    class ReflectionActivity : Activity
    {
        private List<string> Prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private List<string> Questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you feel when it was complete?",
            "What did you learn from this experience?"
        };

        public ReflectionActivity()
        {
            Name = "Reflection Exercise";
            Description = "This activity helps you reflect on times when you showed strength and resilience.";
        }

        protected override void Execute()
        {
            Random random = new Random();
            Console.WriteLine($"\n{Prompts[random.Next(Prompts.Count)]}");
            Console.WriteLine("Reflecting...");

            int questionTime = Duration / Questions.Count;
            foreach (string question in Questions)
            {
                Console.WriteLine($"\n{question}");
                ShowAnimation(questionTime);
            }
        }
    }

    class ListingActivity : Activity
    {
        private List<string> Prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people you have helped this week?",
            "Who are some of your personal heroes?"
        };

        public ListingActivity()
        {
            Name = "Listing Exercise";
            Description = "This activity helps you list positive aspects in your life, promoting gratitude and awareness.";
        }

        protected override void Execute()
        {
            Random random = new Random();
            Console.WriteLine($"\n{Prompts[random.Next(Prompts.Count)]}");
            Console.WriteLine("Start listing items...");
            ShowAnimation(3);

            DateTime endTime = DateTime.Now.AddSeconds(Duration);
            int itemCount = 0;
            while (DateTime.Now < endTime)
            {
                Console.Write("Enter an item: ");
                string item = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(item))
                {
                    itemCount++;
                }
            }

            Console.WriteLine($"\nYou listed {itemCount} items!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Mindfulness App");
                Console.WriteLine("1. Breathing Exercise");
                Console.WriteLine("2. Reflection Exercise");
                Console.WriteLine("3. Listing Exercise");
                Console.WriteLine("4. Quit");
                Console.Write("\nChoose an activity: ");

                string choice = Console.ReadLine();
                Activity activity = choice switch
                {
                    "1" => new BreathingActivity(),
                    "2" => new ReflectionActivity(),
                    "3" => new ListingActivity(),
                    "4" => null,
                    _ => null
                };

                if (activity == null)
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                activity.Start();
            }
        }
    }
}