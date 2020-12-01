using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfArticles = int.Parse(Console.ReadLine());
            ListOfArticles articleList = new ListOfArticles();
            articleList.articlesList = new List<Article>();
            for (int i = 0; i < numbersOfArticles; i++)
            {
                string[] articleInput = Console.ReadLine().Split(", ");
                Article article = new Article(articleInput[0], articleInput[1], articleInput[2]);
                articleList.articlesList.Add(article);

            }

            string orderBy = Console.ReadLine();
            ListOfArticles orderedList = new ListOfArticles();

            if (orderBy == "title")
            {
                orderedList.articlesList= articleList.articlesList.OrderBy(article => article.Title).ToList();
            }
            else if (orderBy == "author")
            {
                orderedList.articlesList= articleList.articlesList.OrderBy(article => article.Author).ToList();

            }
            else
            {
                orderedList.articlesList = articleList.articlesList.OrderBy(article => article.Content).ToList();

            }

            foreach (Article article in orderedList.articlesList)
            {
                Console.WriteLine(Article.ToString(article.Title,article.Content,article.Author));
            }

        }

        public class Article
        {
            public Article(string title, string content, string autor)
            {
                this.Title = title;
                this.Content = content;
                this.Author = autor;
                
            }
            public Article()
            {

            }

            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public static string ToString(string title, string content, string autor)
            {
                return $"{title} - {content}: {autor}";
            }
        }

        public class ListOfArticles
        {
            public ListOfArticles()
            {
                Article article = new Article();
            }
            public List<Article> articlesList { get; set; }
        }

    }
}
