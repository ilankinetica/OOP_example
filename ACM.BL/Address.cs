﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Address
    {
        public Address()
        {

        }
        public Address (int addressId)
        {
            this.AddressId = addressId;
        }
        public int AddressId { get; private set; }
        public int AdressType { get; set; }
        public string StreetLine1 { get; set; }
        public string StreeLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }
}
