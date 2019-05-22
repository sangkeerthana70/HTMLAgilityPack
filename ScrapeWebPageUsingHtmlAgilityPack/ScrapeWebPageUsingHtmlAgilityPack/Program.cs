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
            Console.WriteLine("nodes: " + node.InnerText);

           
            
            var stockName = htmlDoc.DocumentNode
                .SelectSingleNode("//*[@id=\"wsod_marketMoversContainer\"]/table/tbody/tr[4]");
            Console.WriteLine("name: " + stockName);

            Console.WriteLine("Node name: " + stockName.InnerText);   
               
            /*
            var stockList  = new List<Stocks>();
            foreach(var stock in stockList)
            {
               
                Console.WriteLine(stock.Price);
                Console.WriteLine(stock.PercentChange);
                Console.WriteLine(stock.Change);
            }*/




        }
    }
}
