using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    class VicePresidentHandler : ApproverHandler
    {
        public override object Handle(Purchase purchase)
        {
            if (purchase.Amount < 25000.0)
            {
                return $"{this.GetType().Name} approved request# {purchase.Number}\n";
            } 
            else
            {
                return base.Handle(purchase);
            } 
        }
    }
}
