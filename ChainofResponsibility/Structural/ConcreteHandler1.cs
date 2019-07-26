using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            if(request >= 0 && request < 10)
            {
                Console.WriteLine("{0} handle request {1}", this.GetType().Name, request);
            }
            else if(_nextHandler != null)
            {
                _nextHandler.HandleRequest(request);
            }
        }
    }
}
