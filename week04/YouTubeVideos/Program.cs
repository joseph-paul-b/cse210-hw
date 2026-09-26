using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1.Title = "Introduction to C# Programming";
        video1.Author = "Joseph Paul";
        video1.Length = 600;

        Comment comment1 = new Comment();
        comment1.Name = "David";
        comment1.Text = "This video explains C# very clearly.";

        Comment comment2 = new Comment();
        comment2.Name = "Sarah";
        comment2.Text = "I learned a lot from this video.";

        Comment comment3 = new Comment();
        comment3.Name = "Michael";
        comment3.Text = "The examples were very helpful.";

        Comment comment4 = new Comment();
        comment4.Name = "Grace";
        comment4.Text = "Thank you for sharing this.";

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        video1.AddComment(comment4);


        Video video2 = new Video();
        video2.Title = "Understanding Object-Oriented Programming";
        video2.Author = "CSE Student";
        video2.Length = 720;

        Comment comment5 = new Comment();
        comment5.Name = "Daniel";
        comment5.Text = "The explanation of classes was excellent.";

        Comment comment6 = new Comment();
        comment6.Name = "Mary";
        comment6.Text = "This helped me understand objects better.";

        Comment comment7 = new Comment();
        comment7.Name = "John";
        comment7.Text = "I enjoyed the practical examples.";

        Comment comment8 = new Comment();
        comment8.Name = "Rebecca";
        comment8.Text = "Very useful lesson.";

        video2.AddComment(comment5);
        video2.AddComment(comment6);
        video2.AddComment(comment7);
        video2.AddComment(comment8);


        Video video3 = new Video();
        video3.Title = "C# Classes and Objects";
        video3.Author = "Programming Academy";
        video3.Length = 840;

        Comment comment9 = new Comment();
        comment9.Name = "Peter";
        comment9.Text = "Now I understand how objects work.";

        Comment comment10 = new Comment();
        comment10.Name = "Esther";
        comment10.Text = "The class examples were easy to follow.";

        Comment comment11 = new Comment();
        comment11.Name = "Samuel";
        comment11.Text = "Great explanation of abstraction.";

        Comment comment12 = new Comment();
        comment12.Name = "Linda";
        comment12.Text = "I will use this in my next project.";

        video3.AddComment(comment9);
        video3.AddComment(comment10);
        video3.AddComment(comment11);
        video3.AddComment(comment12);


        Video video4 = new Video();
        video4.Title = "Learning C# Collections";
        video4.Author = "Code World";
        video4.Length = 540;

        Comment comment13 = new Comment();
        comment13.Name = "James";
        comment13.Text = "Lists are much easier to understand now.";

        Comment comment14 = new Comment();
        comment14.Name = "Helen";
        comment14.Text = "I liked the examples in this video.";

        Comment comment15 = new Comment();
        comment15.Name = "Robert";
        comment15.Text = "This was a very informative lesson.";

        Comment comment16 = new Comment();
        comment16.Name = "Anna";
        comment16.Text = "Thanks for making programming easier.";

        video4.AddComment(comment13);
        video4.AddComment(comment14);
        video4.AddComment(comment15);
        video4.AddComment(comment16);


        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);


        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}