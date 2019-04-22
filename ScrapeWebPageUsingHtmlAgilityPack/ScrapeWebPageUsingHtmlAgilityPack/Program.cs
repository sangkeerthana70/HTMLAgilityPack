using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrapeWebPageUsingHtmlAgilityPack
{
    class Program
    {
        static void Main(string[] args)
        {
            string html = @"https://money.cnn.com/data/us_markets/";

            HtmlWeb web = new HtmlWeb();

            HtmlDocument htmlDoc = web.Load(html);

            var node = htmlDoc.DocumentNode.SelectNodes("//*[@id=\"wsod_marketMoversContainer\"]").FirstOrDefault();

            

            try
            {
                if (node != null)
                {
                    Console.WriteLine("node: " + node.InnerText);
                }
            }
            catch (System.ArgumentNullException e)
            {
                throw new System.ArgumentNullException(
                    "Node values cannot be null", e);
            }
            finally
            {
                Console.WriteLine("node: " + node.InnerText);
            }






        }
    }
}
