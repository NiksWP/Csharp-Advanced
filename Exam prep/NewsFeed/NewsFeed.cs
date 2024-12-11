using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace NewsFeed
{
    public class NewsFeed
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Article> Articles { get; set; }

        public NewsFeed(string name, int capacity)
        {
            this.Articles = new List<Article>();
            this.Capacity = capacity;
        }

        public void AddArticle(Article article)
        {
            if (this.Capacity + 1 <= Capacity && !(this.Articles.Any(x => x.Title == article.Title)))
            {
                this.Articles.Add(article);
            }
        }

        public bool DeleteArticle(Article article)
        {
            if (this.Articles.Any(x => x.Title == article.Title))
            {
                this.Articles.Remove(article);
                return true;
            }
            return false;
        }

        public Article GetShortestArticle()
        {
            return Articles.OrderBy(x => x.WordCount)[0];
        }

        public GetArticleDetails(string title)
        {
            if (this.Articles.Any(x => x.Title == title))
            {
                Article toReturn = this.Articles.Where(x => x.Title == title)[0];
                return toReturn.ToString();
            }
        }

        public int GetArticlesCount()
        {
            return this.Articles.Count;
        }

        public StringBuilder Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.Name} newsfeed content:");
            foreach (var article in this.Articles)
            {
                sb.AppendLine($"{article.Author}: {article.Title}");
            }

            return sb.ToString();
        }
    }
}
