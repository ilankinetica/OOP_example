using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Common;

namespace ACM.BL
{
    public class Product : ILoggable
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            this.ProductId = productId;
        }
        public int ProductId { get; private set; }
        private string _ProductName;
        public string ProductName
        {
            get
            {
                return _ProductName.InsertSpaces();
            }
            set { _ProductName = value; }
        }
        public Decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;
            return isValid;
        }
        public string Log()
        {
            var logString = this.ProductId + ": " +
                this.ProductName + " - " +
                "Desc: " + this.ProductDescription + " - ";
            return logString;
        }
    }
}
