namespace InterfaceGyakorlas_PCs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamingPlatform streaming = new StreamingPlatform();

            Video video1 = new Video("Shrek", 120);
            Video video2 = new Video("Jégvarázs", 115);
            Video video3 = new Video("1. rész", 40);
            Video video4 = new Video("2. rész", 50);

            Movie film1 = new Movie(video1);
            Movie film2 = new Movie(video2);

            List<Video> reszek = new List<Video>();
            reszek.Add(video3);
            reszek.Add(video4);

            Series sorozat = new Series("Tom és JErry", reszek);

            streaming.AddContent(film1);
            streaming.AddContent(film2);
            streaming.AddContent(sorozat);

            Console.WriteLine("Streaming szolgáltató");
            Console.WriteLine();

            foreach (IContent content in streaming.contents)
            {
                Console.WriteLine($"{content.getTitle()} - {content.getLenght()} perc");
                  
            }

            Console.WriteLine();

            IContent longest = streaming.Leghosszabb();

            Console.WriteLine("Leghosszabb tartalom:");
            Console.WriteLine(longest.getTitle());
            Console.WriteLine(longest.getLenght() + " perc");

            Console.ReadKey();
        
        }
    }
}
