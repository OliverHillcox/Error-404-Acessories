using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {

        List<clsStock> mStockList = new List<clsStock>();
        clsStock mThisStock = new clsStock();
        public List<clsStock> StockList { get { return mStockList; } set { mStockList = value; } }
        public int Count { get { return mStockList.Count; } set { } }
        public clsStock ThisStock { get { return mThisStock; } set {mThisStock = value; } }

        public clsStockCollection()
        {
            Int32 Index = 0;

            Int32 RecordCount = 0;

            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblStock_SelectAll");

            RecordCount = DB.Count;

            while (Index < RecordCount)
            {
                clsStock stock = new clsStock();

                stock.ItemID = Convert.ToInt32(DB.DataTable.Rows[Index]["ItemID"]);
                stock.ItemOver18 = Convert.ToBoolean(DB.DataTable.Rows[Index]["ItemOver18"]);
                stock.ItemDateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["ItemDateAdded"]);
                stock.ItemName = Convert.ToString(DB.DataTable.Rows[Index]["ItemName"]);
                stock.ItemPrice = Convert.ToDouble(DB.DataTable.Rows[Index]["ItemPrice"]);
                stock.ItemQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["ItemQuantity"]);

                mStockList.Add(stock);

                Index++;

            }
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ItemID", mThisStock.ItemID);
            DB.Execute("sproc_tblStock_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ItemID", mThisStock.ItemID);
            DB.AddParameter("@ItemPrice", mThisStock.ItemPrice);
            DB.AddParameter("@ItemQuantity", mThisStock.ItemQuantity);
            DB.AddParameter("@ItemOver18", mThisStock.ItemOver18);
            DB.AddParameter("@ItemDateAdded", mThisStock.ItemDateAdded);
            DB.AddParameter("@ItemName", mThisStock.ItemName);
            DB.Execute("sproc_tblStock_Update");
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ItemPrice", mThisStock.ItemPrice);
            DB.AddParameter("@ItemQuantity", mThisStock.ItemQuantity);
            DB.AddParameter("@ItemOver18", mThisStock.ItemOver18);
            DB.AddParameter("@ItemDateAdded", mThisStock.ItemDateAdded);
            DB.AddParameter("@ItemName", mThisStock.ItemName);
            return DB.Execute("sproc_tblStock_Insert");
        }
    }
}