using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // create at least 3 videos
        var videos = new List<Video>
        {
            new Video("Intro to C#", "BYU-I", 540),
            new Video("LINQ Basics", "Alice Dev", 720),
            new Video("Async/Await Explained", "Bob Code", 615)
        };

        // add at least 3 comments per video
        videos[0].AddComment(new Comment("John", "Great intro!"));
        videos[0].AddComment(new Comment("Maria", "Very clear."));
        videos[0].AddComment(new Comment("Lee", "Helped me a lot."));

        videos[1].AddComment(new Comment("Ana", "Examples were nice."));
        videos[1].AddComment(new Comment("Tom", "Please do part 2."));
        videos[1].AddComment(new Comment("Ruth", "Book tips?"));

        videos[2].AddComment(new Comment("Carlos", "Finally I get it."));
        videos[2].AddComment(new Comment("Zoe", "Good pacing."));
        videos[2].AddComment(new Comment("Kim", "Thanks!"));

        // display info for each video
        foreach (var v in videos)
        {
            Console.WriteLine($"Title: {v.GetTitle()}");
            Console.WriteLine($"Author: {v.GetAuthor()}");
            Console.WriteLine($"Length: {v.GetLengthInSeconds()}s");
            Console.WriteLine($"Comments ({v.GetNumberOfComments()}):");

            foreach (var c in v.GetComments())
            {
                Console.WriteLine($"  - {c.GetName()}: {c.GetText()}");
            }

            Console.WriteLine(new string('-', 40));
        }
    }
}
