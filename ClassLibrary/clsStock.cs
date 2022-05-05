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

        public string Valid(string itemid, string itemname, string itemprice, string itemquantity, string itemover18, string itemdateadded)
        {
            String Error = "";
            DateTime Datetemp;
            Double Pricetemp;
            Int32 Quanttemp;
            Boolean Over18temp;

            if (itemname.Length == 0)
            {
                Error = Error + "Itemname cannot be blank. ";
            }
            if (itemname.Length > 50)
            {
                Error = Error + "Itemname cannot exceed 50 characters. ";
            }

            try
            {
                Pricetemp = Convert.ToDouble(itemprice);
                if (itemprice.Length >= 9)
                {
                    Error = Error + "ItemPrice cannot exceed £100000. ";
                }
                if (Pricetemp <= 0)
                {
                    Error = Error + "ItemPrice cannot be negative or 0.";
                }
            }
            catch
            {
                Error = Error + "ItemPrice must be a valid Double. ";
            }

            try
            {
                Datetemp = Convert.ToDateTime(itemdateadded);
                if (Datetemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past. ";
                }
                if (Datetemp > DateTime.Now.Date)
                {
                    Error = Error + "The data cannot be in the future. ";
                }
            }
            catch
            {
                Error = Error + "DateAdded must be valid. ";
            }

            try
            {
                Quanttemp = Convert.ToInt32(itemquantity);
                if (Quanttemp > 500000)
                {
                    Error = Error + "ItemQuantity must be under or equal to 500,000";
                }
                if (Quanttemp < 0)
                {
                    Error = Error + "ItemQuantity must be over or equal to 0";
                }
            }
            catch
            {
                Error = Error + "ItemQuantity must be valid. ";
            }

            try
            {
                Over18temp = Convert.ToBoolean(itemover18);
            }
            catch
            {
                Error = Error + "Over18 variable must be valid. ";
            }

            return Error;
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
            DB.AddParameter("@ItemID", itemid);
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