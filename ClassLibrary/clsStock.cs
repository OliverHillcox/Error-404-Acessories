using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public bool ItemOver18 { get; set; }
        public DateTime ItemDateAdded { get; set; }
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }
        public int ItemQuantity { get; set; }
    }
}