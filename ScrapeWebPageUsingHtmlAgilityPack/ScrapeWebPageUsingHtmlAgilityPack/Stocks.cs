using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrapeWebPageUsingHtmlAgilityPack
{
    class Stocks
    {
        public float Price { get; set; }
        public float Change { get; set; }
        public float PercentChange { get; set; }
        public string dataSource { get; set; }
        public DateTime createDate { get; set; }

        //public List<Stocks> getStocks = new List<Stocks>();

        public void parseOutput()
        {
            this.Price = Price;
            this.Change = Change;
            
        }
    }
}
