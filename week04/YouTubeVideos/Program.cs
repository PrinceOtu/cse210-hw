using System;
using System.Collections.Generic;

// Class to represent a Comment
class Comment
{
    public string Name { get; set; }
    public string Text { get; set; }

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}

// Class to represent a Video
class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } // Length in seconds
    private List<Comment> Comments { get; set; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public void AddComment(string name, string text)
    {
        Comments.Add(new Comment(name, text));
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");

        foreach (var comment in Comments)
        {
            Console.WriteLine($"- {comment.Name}: {comment.Text}");
        }

        Console.WriteLine();
    }
}

// Main Program class
class Program
{
    static void Main(string[] args)
    {
        // Create a list to store videos
        List<Video> videos = new List<Video>();

        // Create Video 1
        Video video1 = new Video("Exploring the Milky Way", "Astronomy Channel", 720);
        video1.AddComment("Alice", "Fascinating video!");
        video1.AddComment("Bob", "I never knew there were so many stars.");
        video1.AddComment("Charlie", "Amazing visuals!");
        videos.Add(video1);

        // Create Video 2
        Video video2 = new Video("10-Minute Workouts", "Fitness Guru", 600);
        video2.AddComment("David", "Great workout, thank you!");
        video2.AddComment("Eve", "I broke a sweat!");
        video2.AddComment("Frank", "Can you do one for beginners?");
        videos.Add(video2);

        // Create Video 3
        Video video3 = new Video("Cooking 101: Pasta", "Chef's Delight", 900);
        video3.AddComment("Grace", "This recipe is easy to follow!");
        video3.AddComment("Hannah", "I tried this, and it was delicious.");
        video3.AddComment("Ian", "Can you share more pasta recipes?");
        videos.Add(video3);

        // Display video details
        foreach (var video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}