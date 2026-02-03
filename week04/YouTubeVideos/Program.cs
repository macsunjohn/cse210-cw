using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learning C# Basics", "Code Academy", 600);
        video1.AddComment(new Comment("Alice", "Very helpful tutorial!"));
        video1.AddComment(new Comment("Kamal", "Clear and easy to understand."));
        video1.AddComment(new Comment("Kunle", "Great explanation."));
        videos.Add(video1);

        Video video2 = new Video("Object-Oriented Programming", "Tech World", 900);
        video2.AddComment(new Comment("Okafor", "Encapsulation finally makes sense."));
        video2.AddComment(new Comment("Fella", "Loved the examples."));
        video2.AddComment(new Comment("Faruk", "Well structured video."));
        videos.Add(video2);

        Video video3 = new Video("Abstraction Explained", "Dev Simplified", 750);
        video3.AddComment(new Comment("Hanat", "Perfect for beginners."));
        video3.AddComment(new Comment("Henry", "Nice real-world examples."));
        video3.AddComment(new Comment("Chima", "Short and precise."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.GetCommenterName()}: {comment.GetCommentText()}");
            }

            Console.WriteLine();
        }
    }
}