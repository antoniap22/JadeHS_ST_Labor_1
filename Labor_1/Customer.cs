using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.Program;

namespace ConsoleApp1
{
    internal class Customer : Person
    {
        private Address _address;
        private uint _id;

        // Setter für Address
        public void setAddress(string street, uint number, string postcode, string city, string country)
        {
            _address.street = street;
            _address.number = number;
            _address.postcode = postcode;
            _address.city = city;
            _address.country = country;
        }

        // Getter für Address
        public Address address()
        {
            return _address;
        }

        // Setter für ID
        public void setID(uint id)
        {
            _id = id;
        }

        // Getter für ID
        public uint id()
        {
            return _id;
        }

    
    }
}
