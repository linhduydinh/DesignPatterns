using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    abstract class ApproverHandler : IApproverHandler
    {
        protected IApproverHandler _nextHandler;
        public virtual object Handle(Purchase purchase)
        {
            if(this._nextHandler != null)
            {
                return this._nextHandler.Handle(purchase);
            }
            else
            {
                return null;
            }
        }

        public IApproverHandler SetNext(IApproverHandler handler)
        {
            this._nextHandler = handler;

            // Returning a handler from here will let us link handlers in a
            // convenient way like this:
            // monkey.SetNext(squirrel).SetNext(dog);
            return handler;
        }
    }
}
