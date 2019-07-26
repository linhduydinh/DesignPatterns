using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    class SquirrelHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if(request.ToString() == "Nut")
            {
                return $"Squirrel: I'll eat the {request.ToString()}.\n";
            }
            return base.Handle(request);
        }
    }
}
