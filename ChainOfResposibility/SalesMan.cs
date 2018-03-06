using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResposibility
{
    public class SalesMan : Handler
    {
        public override string HandleDiscount(double discountPercent)
        {
            if (discountPercent <= 5)
                return "Discount granted by salesman";

            if (Sucessor != null)
                return Sucessor.HandleDiscount(discountPercent);

            return base.HandleDiscount(discountPercent);
        }
    }
}
