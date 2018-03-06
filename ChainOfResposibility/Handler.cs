using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResposibility
{
    public abstract class Handler
    {
        protected Handler Sucessor;

        public void SetSucessor(Handler sucessor)
        {
            Sucessor = sucessor;
        }
        public virtual string HandleDiscount(double discountPercent)
        {
            return "There's no handle for that request";
        }
        
    }
}
