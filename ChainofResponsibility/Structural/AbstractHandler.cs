using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    abstract class Handler
    {
        protected Handler _nextHandler;
        public abstract void HandleRequest(int request);

        public void SetSuccessor(Handler handler)
        {
            this._nextHandler = handler;
        }
    }
}
