using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {

        List<Video> videos = new List<Video>();
        List<string> titlesOfVideos = new List<string>{
            "Learning C#",
            "Learning How to Drive",
            "Learning How to Cook",
        };
        List<string> Youtubers = new List<string>
        {
            "RandomYoutuber",
            "YourdriverInstructor123",
            "Fernanfloo",
        };
        List<int> durationOfVideos = new List<int>{1523, 531, 1204};
        List<Comment> genericComments = new List<Comment>
        {
            new Comment("Alice","Great Video"),
            new Comment("Boby","Hey man, Great video!, You deserve more subscribers!"),
            new Comment("Emmanuel","Thanks man! I will subscribe to your channel to watch more or your videos!"),
            new Comment("Anonimus123","You are the best! I will share this video with all my friends!"),
            new Comment("Rodriguez","You should start a stream on Twitch!"),
        };

        for(int i = 0; i < titlesOfVideos.Count; i++)
        {
            Video video = new Video(titlesOfVideos[i], Youtubers[i], durationOfVideos[i]);
            foreach(Comment comment in genericComments)
            {
                video.AddComment(comment);
            }
            videos.Add(video);
        }

        foreach(Video video in videos)
        {
            Console.WriteLine("\nVideo:");
            video.DisplayVideo();
        }
    }
}