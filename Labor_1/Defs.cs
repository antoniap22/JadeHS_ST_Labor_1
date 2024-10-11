using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal partial class Program
    {
        const int OK = 0;
        const int ERROR = 1;
        public enum MONTH { JAN=1, FEB, MAR, APR, MAY, JUN, JUL, AUG, SEP, OCT, NOV, DEC };

        public struct Date
        {
            public int day;
            public MONTH month;
            public int year;
        }

        public struct Address
        {
            public string street;
            public uint number;
            public string postcode;
            public string city;
            public string country;
        }
    }
}
