using System;

namespace ChainofResponsibility
{
    class DirectorHandler : ApproverHandler
    {
        public override object Handle(Purchase purchase)
        {
            if (purchase.Amount < 10000.0)
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
