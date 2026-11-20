using System;

class Program
{
    static void Main(string[] args)
    {
        
        
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Make Homemade Pizza", "Sarah's Kitchen", 645);
        Video video2 = new Video("Beginner's Guide to C#", "Code Academy", 1200);
        Video video3 = new Video("Exploring Yellowstone National Park", "Adventure Travels", 890);
        Video video4 = new Video("10 Tips for Better Productivity", "Daily Improvement", 510);
        

        video1.AddComment("John", "This recipe turned out amazing!");
        video1.AddComment("Lisa", "I added extra cheese and loved it.");
        video1.AddComment("Mike", "Great instructions for beginners.");
        video1.AddComment("Sarah", "Definitely making this again.");

        videos.Add(video1);

        video2.AddComment("David", "Very helpful explanation of classes.");
        video2.AddComment("Jessica", "Looking forward to the next lesson.");
        video2.AddComment("Robert", "This finally made constructors click!");

        videos.Add(video2);

        video3.AddComment("Emily", "The scenery is incredible!");
        video3.AddComment("Chris", "I visited last summer. Such a beautiful place.");
        video3.AddComment("Amanda", "Adding this to my travel bucket list.");
        video3.AddComment("James", "Great video and editing.");


        videos.Add(video3);

        video4.AddComment("Michelle", "Tip number three changed my routine.");
        video4.AddComment("Daniel", "Really useful advice.");
        video4.AddComment("Ashley", "I needed this today!");

        videos.Add(video4);


        Console.Clear();

        foreach (Video video in videos)
        {
            video.Display();
        }
        



    }
}