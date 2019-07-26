using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    class PurchaseClient
    {
        public static void ClientCode(ApproverHandler handler)
        {
            var listPurchases = new List<Purchase>();
            Purchase p1 = new Purchase(2034, 350.00, "Assets");
            Purchase p2 = new Purchase(2035, 32590.10, "Project X");
            Purchase p3 = new Purchase(2036, 122100.00, "Project Y");
            listPurchases.Add(p1);
            listPurchases.Add(p2);
            listPurchases.Add(p3);
            foreach (var purchase in listPurchases)
            {
                Console.WriteLine($"Client: Project purpose {purchase.Purpose}");

                var result = handler.Handle(purchase);

                if(result != null)
                {
                    Console.Write($"   {result}");
                }
                else
                {
                    Console.WriteLine($"   {purchase.Purpose} was left untouched");
                }
            }
        }
    }
}
