using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResposibility
{
    public class Manager : Handler
    {
        public override string HandleDiscount(double discountPercent)
        {
            if (discountPercent <= 15)
            {
                return "Discount granted by Manager";
            }
            if (Sucessor != null)
                return Sucessor.HandleDiscount(discountPercent);

            return base.HandleDiscount(discountPercent);
        }
    }
}
