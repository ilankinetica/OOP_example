using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Common;

namespace ACM.BL
{
    public class Customer : ILoggable //hereda ILoggable
    {
        public Customer()
        {
            //para crear un constructor o modificar un contructos hau que crear si o si este sin parametros
        }
        public Customer(int idCustomer)
        {
            this.IdCustomer = idCustomer;
        }
        //puede ser vista desde afuera pero no seteada
        public int IdCustomer { get; private set; }
        //esta propiedad puede ser vista y modificada desde afuera
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        //public string HomeAddress { get; set; }
        //public string WorkAddress { get; set; }
        //lo modifico cuando creo mi class Addess
        public List<Address> AdressList { get; set; }
        //tampoco puede ser seteada desde afuera
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }
        public bool Validate()
        {
            //una pequeña validacion demostrativa
            var isValid = true; //el return
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false; //check
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            return isValid; //return la validacion
        }
        public string Log()
        {
            //escribimos el mensaje en el log
            var logString = this.IdCustomer + ": " +
                this.FullName + " - " +
                "Mail: " + this.EmailAddress + " - ";
            return logString;
        }
    }
}
