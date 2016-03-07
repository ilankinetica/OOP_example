using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class OrderRepository
    {
        public Order Retrieve()
        {
            //identificamos una relacion de colaboracion: CustomerRepository usa un Customer
            return new Order();
        }
        public bool save()
        {
            return true;
        }
    }
}
