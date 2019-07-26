using System;
using Command.Calculator;
using Command.Structural;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////
            //Receiver receiver = new Receiver();
            //ConcreteCommand command = new ConcreteCommand(receiver);
            //Invoker invoker = new Invoker();

            //invoker.SetCommand(command);
            //invoker.ExecuteCommand();
            //Console.ReadKey();

            ////////
            /// // Create user and let her compute
            User user = new User();

            // User presses calculator buttons
            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);

            // Undo 4 commands
            user.Undo(4);

            // Redo 3 commands
            user.Redo(3);

            // Wait for user
            Console.ReadKey();


        }
    }
}
