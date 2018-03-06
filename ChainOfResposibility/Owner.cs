using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResposibility
{
    public class Owner : Handler
    {
        public override string HandleDiscount(double discountPercent)
        {
            if(discountPercent <= 100)
            {
                return "Discount granted by the owner";
            }

            if(discountPercent > 100)
            {
                throw new ArgumentException("The discount canot overcome 100%");
            }
            return base.HandleDiscount(discountPercent);
        }
    }
}
