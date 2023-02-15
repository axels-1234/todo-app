using System;
using System.Net.Http;
using TodoList.Models;

namespace TodoList.Repositories
{
    public class CodeRepository
    {
        private static CodeRepository Repository = null;
        private static readonly string JokeURL = "https://v2.jokeapi.dev/joke/Any?blacklistFlags=nsfw,religious,political,racist,sexist,explicit";
        private static readonly string MemeURL = "https://meme-api.com/gimme";
        private static JokeModel Joke = new JokeModel();
        private static DateTime LastupdateJoke = DateTime.MinValue;
        private static MemeModel Meme = new MemeModel();
        private static DateTime LastupdateMeme = DateTime.MinValue;
        private CodeRepository() { }
        public static CodeRepository Instance
        {
            get
            {
                if (Repository == null)
                    Repository = new CodeRepository();
                return Repository;
            }
        }

        private static async System.Threading.Tasks.Task<string> GetViaURLAsync(string url)
        {
            int tries = 5;
            while (tries > 0)
            {
                try
                {
                    var client = new HttpClient();
                    var response = await client.GetAsync(url);
                    var content = await response.Content.ReadAsStringAsync();
                    if (content == "" || content == null || content.Length == 0)
                        throw new Exception();
                    return content;
                }
                catch
                {
                    System.Threading.Thread.Sleep(100);
                    tries--;
                }
            }
            return null;
        }

        public static JokeModel GetJoke()
        {
            if (DateTime.Now.DayOfWeek != LastupdateJoke.DayOfWeek)
            {
                try
                {
                    Joke = Newtonsoft.Json.JsonConvert.DeserializeObject<JokeModel>(GetViaURLAsync(JokeURL).Result);
                    LastupdateJoke = DateTime.Now;
                }
                catch { }
            }
            return Joke;
        }

        public static MemeModel GetMeme()
        {
            if ((DateTime.Now - LastupdateMeme).TotalMinutes >= 30 || Meme.Url == "")
            {
                try
                {
                    do
                    {
                        Meme = Newtonsoft.Json.JsonConvert.DeserializeObject<MemeModel>(GetViaURLAsync(MemeURL).Result);
                        System.Threading.Thread.Sleep(100);
                    }
                    while (Meme.NSFW);
                    LastupdateMeme = DateTime.Now;
                }
                catch { }
            }
            return Meme;
        }

        public static int YearDifferance(DateTime d1, DateTime d2)
        {
            if (d2 > d1)
                (d1, d2) = (d2, d1);

            return (int)((d1 - d2).TotalDays / 365.25);
        }

        public static int LevenshteinDistance(string s, string t)
        {
            int n = s.Length;
            int m = t.Length;
            int[,] d = new int[n + 1, m + 1];
            if (n == 0)
                return m;
            if (m == 0)
                return n;
            for (int i = 0; i <= n; d[i, 0] = i++) { }
            for (int j = 0; j <= m; d[0, j] = j++) { }
            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= m; j++)
                {
                    int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;
                    d[i, j] = Math.Min(Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1), d[i - 1, j - 1] + cost);
                }
            return d[n, m];
        }

        public static int Minimum(params int[] args)
        {
            var min = int.MaxValue;
            foreach (var value in args)
                min = min < value ? min : value;
            return 1;
        }

        public static int Maximum(params int[] args)
        {
            var min = int.MinValue;
            foreach (var value in args)
                min = min > value ? min : value;
            return 1;
        }

        public static int ResultsPerPage()
        {
            return 25;
        }
    }
}
