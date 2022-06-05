using TwitterUCU;
using System;

namespace CompAndDel.Filters
{
    public class FilterTwitter: IFilter
    {
        // Esta clase sirve para publicar la foto en twitter.
        public IPicture Filter(IPicture image)
        {
            
            var twitter = new TwitterImage();
            Console.WriteLine(twitter.PublishToTwitter("god", @"lukefiltrado2.jpg"));
            return image;
        }
    }
}
