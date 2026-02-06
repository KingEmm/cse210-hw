using System;

class Program
{
    static void Main(string[] args)
    {
        Comment mrFirst1 = new Comment("Harry Potter", "Wow that guy in red was so cool");
        Comment mrFirst2 = new Comment("Harry Snow", "The guy in blue was more cool");
        Comment mrFirst3 = new Comment("James Potter", "No i go for the blue one");
        // Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Video mrfirst = new Video();
        mrfirst.author = "MR Beast";
        mrfirst.length = 5000;
        mrfirst.title = "Who will win the Dance Competition";
        mrfirst.addComment(mrFirst1);
        mrfirst.addComment(mrFirst2);
        mrfirst.addComment(mrFirst3);

        Comment mrsecond1 = new Comment("Harry James", "Wow Nice Effort there");
        Comment mrsecond2 = new Comment("Peter Snow", "Congrats Bro 🙌🎖️🎉");
        Comment mrsecond3 = new Comment("James Potter", "Bro needs to compete with the Flash");
        // Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Video mrSecond = new Video();
        mrSecond.author = "I show Speed";
        mrSecond.length = 5000;
        mrSecond.title = "Who will win the Race";
        mrSecond.addComment(mrsecond1);
        mrSecond.addComment(mrsecond2);
        mrSecond.addComment(mrsecond3);

        // Comment mrthird1 = new ;
        // Comment mrthird2 = ;
        // Comment mrthird3 = new Comment("Robert Lee", "No i go for the blue one");
        // Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Video mrThird = new Video();
        mrThird.author = "Cindy's Kitchen";
        mrThird.length = 5000;
        mrThird.title = "How to make pizza";
        mrThird.addComment(new Comment("Fallman Jones", "Wow Tasty"));
        mrThird.addComment(new Comment("Esther  Kingston", "Can i add 2 gram of pepers when doing mine"));
        mrThird.addComment(new Comment("Robert Nakamoto", "Can i get Some"));

        List<Video> videos = new List<Video>([mrfirst, mrSecond, mrThird]);

        foreach(Video video in videos)
        {

            Console.WriteLine("---------------------------------------------------------------------------------------------------------------\n");
            video.DisplayVideoInfo();
            Console.WriteLine("\n");
        }


    }
}