using System;
using System.Collections.Generic;

namespace P02.Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            int num = int.Parse(Console.ReadLine());
            Article article = new Article(input[0], input[1], input[2]);

            for (int i = 0; i < num; i++)
            {
                string[] commands = Console.ReadLine().Split(": ");
                if (commands[0] == "Edit")
                {
                    article.Edit(commands[1]);
                }
                else if (commands[0] == "ChangeAuthor")
                {
                    article.ChangeAuthor(commands[1]);
                }
                else if (commands[0] == "Rename")
                {
                    article.Rename(commands[1]);
                }
            }
            Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
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
            public void Edit (string newContent)
            {
                Content = newContent;
            }
            public void ChangeAuthor (string newAuthor)
            {
                Author = newAuthor;
            }
            public void Rename (string NewTitle)
            {
                Title = NewTitle;
            }
            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
    }
}
