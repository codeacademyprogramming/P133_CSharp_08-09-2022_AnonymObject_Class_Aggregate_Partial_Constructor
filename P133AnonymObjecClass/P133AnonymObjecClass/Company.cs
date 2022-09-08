using System;
using System.Collections.Generic;
using System.Text;

namespace P133AnonymObjecClass
{
    class Company
    {
        public string Name;
        public string Logo;
        public Address Address;

        public string GetFullInfo()
        {
            return $"Name: {Name}\nLogo: {Logo}\n{Address.GetAddress()}";
        }
    }
}
