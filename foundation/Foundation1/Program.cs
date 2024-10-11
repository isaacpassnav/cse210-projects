// Program.cs
using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Create videos with valid data
        Video video1 = new Video("Learn C# in 10 Minutes", "John Doe", 600);
        Video video2 = new Video("Advanced C# Programming", "Jane Smith", 1200);
        Video video3 = new Video("C# Best Practices", "Emily Johnson", 900);

        // Add comments to videos
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "I learned a lot."));

        video2.AddComment(new Comment("Dave", "I love the explanations."));
        video2.AddComment(new Comment("Eve", "Clear and concise!"));
        video2.AddComment(new Comment("Frank", "Can't wait for the next one!"));

        video3.AddComment(new Comment("George", "Interesting tips!"));
        video3.AddComment(new Comment("Helen", "Perfect for beginners!"));
        video3.AddComment(new Comment("Ivy", "Keep it up!"));

        // Add videos to list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine();
        }
    }
}
