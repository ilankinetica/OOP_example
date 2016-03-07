using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            //obtiene los datos de la base
            Address address = new Address(addressId);
            return address;
        }
        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            //obtiene las distintas sddresses del customer
            //base de datos...
            var addressList = new List<Address>();
            return addressList;
        }
        public bool Save(Address address)
        {
            //guarda la address
            return true;
        }
    }
}
