using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static News_Publisher_Subscriber_Example.Program;

namespace News_Publisher_Subscriber_Example
{
    internal class Program
    {
        public class NewsArticle
        {
            public string Title { get; }
            public string Content { get;  }

            public NewsArticle (string title, string content)
            {
                Title = title;
                Content = content;
            }
        }

        public class NewsBublisher
        {
            public event EventHandler<NewsArticle> NewNewsPublished;

            public void PublishNews(string Title, string Content)
            {
                NewsArticle article = new NewsArticle(Title, Content);
                onNewsPublisher(article);
            }

            protected virtual void onNewsPublisher(NewsArticle news)
            {
                NewNewsPublished?.Invoke(this, news);

            }
           
        }


        //
        public class NewsSubscriber
        {
            public string Name { get; }
            public NewsSubscriber(string Name)
            {
                this.Name = Name;
            }

            public void Subscribe(NewsBublisher Publisher)
            {
                Publisher.NewNewsPublished += HandleNewNews;
            }

            public void Unsubscribe(NewsBublisher Publisher)
            {
                Publisher.NewNewsPublished -= HandleNewNews;
            }

            public void HandleNewNews(object sender, NewsArticle article)
            {
                Console.WriteLine($"{Name} Recieved a new news article:");
                Console.WriteLine($"Ttile: {article.Title}");
                Console.WriteLine($"Content: {article.Content}");
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            NewsBublisher publisher = new NewsBublisher();
            NewsSubscriber subscriber1 = new NewsSubscriber("Subscriper 1");

            subscriber1.Subscribe(publisher);

            NewsSubscriber subscriber2 = new NewsSubscriber("Subscriper 2");
            subscriber2.Subscribe(publisher);


            publisher.PublishNews("Breaking News", "A significant event just happened!");
            publisher.PublishNews("Tech Update", "New Gadgets are htting the market.");

            subscriber1.Unsubscribe(publisher);
            publisher.PublishNews("Weather Forcast", "Expected sunny weather for the weekend.");

            subscriber2.Unsubscribe(publisher);
            publisher.PublishNews("Final Edition", "Last news update for today.");

            Console.ReadLine();

        }
    }
}
