using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        public clsStockCollection()
        {
        }

        public List<clsStock> StockList { get; set; }
        public clsStock ThisStock { get; set; }
        public int Count { get; set; }
    }
}