namespace TodoList.Models
{
    public class MemeModel
    {
        public string PostLink { get; set; }
        public string Subreddit { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public bool Spoiler { get; set; }
        public bool NSFW { get; set; }
        public string Author { get; set; }
        public int Ups { get; set; }
        public string[] Preview { get; set; }
    }
}
