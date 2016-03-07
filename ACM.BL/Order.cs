using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order : ILoggable
    {
        public Order()
        {

        }
        public Order(int idOrder)
        {
            this.OrderId = idOrder;
        }
        public int CustomerId { get; set; }
        public int ShippingIdAdress { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }
        public bool Validate()
        {
            //una pequeña validacion
            var isValid = true;
            if (OrderDate == null) isValid = false;
            return isValid;
        }
        public string Log()
        {
            //logging
            var logString = this.OrderId + ": " +
                "Date " + this.OrderDate.ToString();
            return logString;
        }
    }
}
