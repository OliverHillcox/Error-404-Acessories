using System;

namespace ClassLibrary
{
    public class clsStock
    {
        private int mItemID;
        private bool mItemOver18;
        private DateTime mItemDateAdded;
        private string mItemName;
        private double mItemPrice;
        private int mItemQuantity;

        public bool ItemOver18
        {
            get
            {
                return mItemOver18;
            }
            set
            {
                mItemOver18 = value;
            }
        }
        public DateTime ItemDateAdded
        {
            get
            {
                return mItemDateAdded;
            }
            set
            {
                mItemDateAdded = value;
            }
        }
        public int ItemID
        {
            get
            {
                return mItemID;
            }
            set
            {
                mItemID = value;
            }
        }
        public string ItemName
        {
            get
            {
                return mItemName;
            }
            set
            {
                mItemName = value;
            }
        }
        public double ItemPrice
        {
            get
            {
                return mItemPrice;
            }
            set
            {
                mItemPrice = value;
            }
        }
        public int ItemQuantity
        {
            get
            {
                return mItemQuantity;
            }
            set
            {
                mItemQuantity = value;
            }
        }

        public bool Find(int itemid)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ItemID", ItemID);
            DB.Execute("sproc_tblStock_FilterByItemid");
            if (DB.Count == 1)
            {
                mItemID = Convert.ToInt32(DB.DataTable.Rows[0]["ItemID"]);
                mItemDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["ItemDateAdded"]);
                mItemName = Convert.ToString(DB.DataTable.Rows[0]["ItemName"]);
                mItemOver18 = Convert.ToBoolean(DB.DataTable.Rows[0]["ItemOver18"]);
                mItemPrice = Convert.ToDouble(DB.DataTable.Rows[0]["ItemPrice"]);
                mItemQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["ItemQuantity"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}