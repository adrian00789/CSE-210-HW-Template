using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Video1", "Author1", 120);
        video1.AddComment(new Comment("Commenter1", "This is a comment."));
        video1.AddComment(new Comment("Commenter2", "This is another comment."));
        videos.Add(video1);

        Video video2 = new Video("Video2", "Author2", 240);
        video2.AddComment(new Comment("Commenter3", "This is a comment."));
        video2.AddComment(new Comment("Commenter4", "This is another comment."));
        videos.Add(video2);

        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video._title);
            Console.WriteLine("Author: " + video._author);
            Console.WriteLine("Length: " + video._length);
            Console.WriteLine("Number of comments: " + video.GetNumberOfComments());

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine("Comment by " + comment._commenter + ": " + comment._text);
            }

            Console.WriteLine();
        }
    }
}