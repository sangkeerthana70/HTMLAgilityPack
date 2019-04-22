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

            //var node = htmlDoc.DocumentNode.SelectSingleNode("//*[@id=\"kp - wp - tab - MARKET_SUMMARY\"]/div[1]/div/div[1]/div[1]/div");
            //HtmlNodeCollection rowsNodesList = htmlDoc.DocumentNode.SelectNodes("//*[@id=\"wsod_whatsMoving\"]");
            var node = htmlDoc.DocumentNode.SelectNodes("//*[@id=\"wsod_whatsMoving\"]").First();
            Console.WriteLine("node: " + node.InnerText);
            

            
            
        }
    }
}
