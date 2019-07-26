using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Calculator
{
    class CalculatorCommand : Command
    {
        private Calculator _calculator;
        private int _operand;
        private char _operator;
        public CalculatorCommand(Calculator calculator, char @operator, int operand)
        {
            this._calculator = calculator;
            this._operand = operand;
            this._operator = @operator;
        }

        public char Operator
        {
            set { _operator = value; }
        }

        public int Operand
        {
            set { _operand = value; }
        }

        public override void Execute()
        {
            _calculator.Operation(_operator, _operand);
        }

        public override void UnExecute()
        {
            _calculator.Operation(Undo(_operator), _operand);
        }

        private char Undo(char @operator)
        {
            switch(@operator)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default: throw new ArgumentException("@operator");
            }
        }
    }
}
