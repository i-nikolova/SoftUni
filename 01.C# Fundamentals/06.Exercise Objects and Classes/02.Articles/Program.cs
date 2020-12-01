using System;
using System.Collections.Generic;


namespace _02.Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] articleInput = Console.ReadLine().Split(", ");
            Article article = new Article(articleInput[0], articleInput[1], articleInput[2]);
            int numberOfComands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfComands; i++)
            {
                string[] command = Console.ReadLine().Split(": ",StringSplitOptions.RemoveEmptyEntries);
                if (command[0]=="Edit")
                {
                    article.Edit(command[1]);
                }
                else if (command[0]=="ChangeAuthor")
                {
                    article.ChangeAutor(command[1]);
                }
                else
                {
                    article.Rename(command[1]);
                }
            }

            Console.WriteLine(article.ToString(article.Title,article.Content,article.Autor));
        }
    }

    public class Article
    {
        public Article(string title,string content,string autor)
        {
            this.Title = title;
            this.Content = content;
            this.Autor = autor;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Autor { get; set; }

        public void Edit(string content)
        {
            Content = content;
        }
        public void ChangeAutor (string autor)
        {
            Autor = autor;
        }
        public void Rename (string title)
        {
            Title = title;
        }
        public string ToString(string title,string content,string autor)
        {
            return $"{title} - {content}: {autor}";
        }
    }
}
