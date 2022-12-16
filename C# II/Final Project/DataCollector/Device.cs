using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCollector
{
    public class Device
    {
        //this generates a random number between 1 and 10
        public int GetMeasurement() {
            Random rNum = new Random();
            return rNum.Next(10)+1;
        }

    }
}
