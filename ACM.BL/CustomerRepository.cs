using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        private AddressRepository addressRepository { get; set; }
        //la hago privada porque nadie mas aparte de esta clase necesita usar esta propiedad
        public CustomerRepository()
        {
            //lo instancio directo en el cosntructor
            addressRepository = new AddressRepository();
        }
        public Customer Retrieve(int customerId)
        {
            //obtengo de la vase los datos del customer
            Customer customer = new Customer(customerId);
            //le pongo la idreccion
            customer.AdressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            return customer;
        }
        public List<Customer> Retrieve()
        {
            //devuelve todos los customer
            //conecto a la base de datos
            return new List<Customer>();
        }
        public bool Save (Customer customer)
        {
            //saving to the database...
            return true;
        }
    }
}
