using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    class MonkeyHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if(request.ToString() == "Banana")
            {
                return $"Monkey: I'll eat the {request.ToString()}.\n";
            }
            return base.Handle(request);
        }
    }
}
