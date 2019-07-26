using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    class DogHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if(request.ToString() == "MeatBall")
            {
                return $"Dog: I'll eat the {request.ToString()}.\n";
            }
            return base.Handle(request);
        }
    }
}
