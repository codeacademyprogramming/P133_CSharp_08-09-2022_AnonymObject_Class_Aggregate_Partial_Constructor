using System;
using System.Collections.Generic;
using System.Text;

namespace P133AnonymObjecClass
{
    class Address
    {
        public string Country;
        public string City;
        public string ZipCode;

        public string GetAddress()
        {
            return $"Country: {Country}\nCity: {City}\nZip Code: {ZipCode}";
        }
    }
}
