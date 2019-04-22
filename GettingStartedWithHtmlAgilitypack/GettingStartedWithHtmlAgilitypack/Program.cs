using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStartedWithHtmlAgilitypack
{
    class Program
    {
        static void Main(string[] args)
        {
            // load a page from Internet
            HtmlWeb web = new HtmlWeb();
            HtmlDocument document = web.Load("https://www.wikipedia.org/wiki/Plant");

            // print contents of the web page
            Console.WriteLine(document.DocumentNode.OuterHtml);
            var node = document.DocumentNode.SelectSingleNode("//*[@id=\"bodyContent\"]");
            Console.WriteLine("Node Name: " + node.Name + "\n" + node.OuterHtml);

            // load from a file
            //HtmlDocument document2 = new HtmlDocument();
            //Console.WriteLine(document2.Load(@"c:\Users\anuradha\source\repos\HtmlAgilityPack\SampleHtml.txt"));


        }
    }
}
