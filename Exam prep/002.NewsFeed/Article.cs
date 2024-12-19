using System.Reflection.Metadata;

namespace NewsFeed
{
    public class Article
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int WordCount { get; set; }

        public Article(string title, string author, int wordCount) 
        {
            this.Title = title;
            this.Author = author;
            this.WordCount = wordCount;
        }

		public override string ToString()
		{
            return $"Article: {this.Title} by {this.Author} - {this.WordCount} words";
		}
	}
}
