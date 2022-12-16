using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerSubscription
{
    class Customer : Person
    {
        //constructor
        public Customer(string name, string phone, string address, int custNum, bool subbed) 
        :base(name,phone,address)
        {
            CustNum = custNum;
            Subbed = subbed;
        }
        //properties
        public int CustNum { get; set; }
        public bool Subbed { get; set; }

        public override string ToString()
        {
            return (CustNum + "," + Name + "," + Phone + "," + Address + "," + Subbed);
        }
    }
}
