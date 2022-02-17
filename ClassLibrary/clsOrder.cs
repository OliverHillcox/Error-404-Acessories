using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool Dispatched { get; set; }
        public DateTime DateofPurchase { get; set; }
        public string Address { get; set; }
        public double OrderPrice { get; set; }
        public int OrderQnty { get; set; }
        public int OrderNo { get; set; }
    }
}