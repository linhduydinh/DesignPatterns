using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 10 && request < 20)
            {
                Console.WriteLine("{0} handle request {1}", this.GetType().Name, request);
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(request);
            }
        }
    }
}
