using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerSubscription
{
    abstract class Person
    {
        //constructor
        public Person(string n, string p, string a) {
            Name = n;
            Phone = p;
            Address = a;
        }

        //properties
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

    }
}
