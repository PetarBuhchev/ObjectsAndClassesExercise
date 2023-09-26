using System;
using System.Collections.Generic;

namespace P03.Articles2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListOfArticles listOfArticles = new ListOfArticles();
            listOfArticles.Articles = new List<Article>();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                Article article = new Article(input[0], input[1], input[2]);
                listOfArticles.Articles.Add(article);
            }
            Console.WriteLine(listOfArticles.ToString());
        }
        public class Article
        {
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public Article(string title, string content, string author)
            {
                Title = title;
                Content = content;
                Author = author;
            }
            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }

        }
            public class ListOfArticles
            {
                public List<Article> Articles { get; set; }
            public override string ToString()
            {
                string result = "";
                foreach (Article article in Articles)
                {
                    result += article.ToString() + Environment.NewLine;
                }
                return result;
            }
            }
    }
}
