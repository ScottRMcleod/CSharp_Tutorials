using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibary
{
    public class Vendor
    {
        public string FristName { get; set; }
        public string LastName { get; set; }
        public double Comission { get; set; }
        public decimal PaymentDue { get; set; }

        public Vendor()
        {
            Comission = .5;
        }

        public string Display
        {
            get
            {
                return string.Format(" {0} {1}- ${2}", FristName, LastName, PaymentDue);
            }
        }
    }
}
