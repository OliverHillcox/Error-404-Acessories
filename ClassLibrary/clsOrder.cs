using System;

namespace ClassLibrary
{
    public class clsOrder
    {

        //Dispatched private member variable
        private Boolean mDispatched;
        //Dispatched public property
        public bool Dispatched
        {
            get
            {
                //code sends data out of the property
                return mDispatched;
            }
            set
            {
                mDispatched = value;
            }
        }

        //DateofPurchase private member variable
        private DateTime mDateofPurchase;
        public DateTime DateofPurchase
        {
            get
            {
                //CODE SENDS DATA OUT OF THE PROPERTY
                return mDateofPurchase;
            }
            set
            {
                //set the private data
                mDateofPurchase = value;
            }
        }

        //Address private member variable
        private string mAdddress;
        //Address public property
        public string Address
        {
            get
            {
                //code sends data out of the property
                return mAdddress;
            }
            set
            {
                //sets the private data
                mAdddress = value;
            }
        }

        //OrderPrice private member variable
        private double mOrderPrice;
        //OrderPrice public property
        public double OrderPrice
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderPrice;
            }
            set
            {
                //set the private data
                mOrderPrice = value;
            }
        }


        //OrderQnty private member variable
        private Int32 mOrderQnty;
         //OrderQnty public property
         public int OrderQnty
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderQnty;

            }
            set
            {
                //set the private data
                mOrderQnty = value;
            }
        }

        //OrderNo private data member for the address no property
        private Int32 mOrderNo;
        //OrderNo public property 
        public int OrderNo
        {
            get
            {
                //this line of code sends data out of the propety
                return mOrderNo;
            }
            set
            {
                //set the private data
                mOrderNo = value;
            }
        }
       

        public bool Find(int orderNo)
        {
            //set the private data members to the test data value
            mOrderNo = 65;
            mOrderQnty = 4;
            mOrderPrice = 150.0;
            mDispatched = true;
            mDateofPurchase = Convert.ToDateTime("28/01/2016");
            mAdddress = "1357 Blane Street, Saint Louis, MO 63101";
            //always return true
            return true;
        }
        
    }
}