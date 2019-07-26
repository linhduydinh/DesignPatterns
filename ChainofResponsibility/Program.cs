using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {

            //// Setup Chain of Responsibility
            //Handler h1 = new ConcreteHandler1();
            //Handler h2 = new ConcreteHandler2();
            //Handler h3 = new ConcreteHandler3();
            //h1.SetSuccessor(h2);
            //h2.SetSuccessor(h3);

            //// Generate and process request
            //int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };

            //foreach (int request in requests)
            //{
            //    h1.HandleRequest(request);
            //}

            //// Wait for user
            //Console.ReadKey();

            //////////////////////////////////////
            // The other part of the client code constructs the actual chain.
            //var monkey = new MonkeyHandler();
            //var squirrel = new SquirrelHandler();
            //var dog = new DogHandler();

            //monkey.SetNext(squirrel).SetNext(dog);

            //// The client should be able to send a request to any handler, not just the first one in the chain.
            //Console.WriteLine("Chain: Monkey > Squirrel > Dog\n");
            //Client.ClientCode(monkey);
            //Console.WriteLine();

            //Console.WriteLine("Subchain: Squirrel > Dog\n");
            //Client.ClientCode(squirrel);

            //////////////////////////////////////
            // The other part of the client code constructs the actual chain.
            var director = new DirectorHandler();
            var vicePresident = new VicePresidentHandler();
            var president = new PresidentHandler();

            director.SetNext(vicePresident).SetNext(president);

            // The client should be able to send a request to any handler, not just the first one in the chain.
            Console.WriteLine("Chain: Director > VicePresident > President\n");
            PurchaseClient.ClientCode(director);
            Console.WriteLine();

        }
    }
}
