using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_section1
{
    public class Calculator
    {
        private decimal currentValue;
        private decimal operand1;
        private decimal operand2;
        private string op;

        public Calculator()
        {
            currentValue = 0;
            operand1 = 0;
            operand2 = 0;
            op = null;
        }

        public decimal CurrentValue
        {
            get { return currentValue; }
        }

        public void Add(decimal displayValue)
        {
            operand1 = displayValue;
            currentValue = operand1;
            op = "+";
        }

        public void Subtract(decimal displayValue)
        {
            operand1 = displayValue;
            currentValue = operand1;
            op = "-";
        }

        public void Multiply(decimal displayValue)
        {
            operand1 = displayValue;
            currentValue = operand1;
            op = "*";
        }

        public void Divide(decimal displayValue)
        {
            operand1 = displayValue;
            currentValue = operand1;
            op = "/";
        }

        public void Equals()
        {
            switch (op)
            {
                case "+":
                    currentValue += operand2;
                    break;
                case "-":
                    currentValue -= operand2;
                    break;
                case "*":
                    currentValue *= operand2;
                    break;
                case "/":
                    if (operand2 != 0)
                    {
                        currentValue /= operand2;
                    }
                    else
                    {
                        throw new DivideByZeroException("Cannot divide by zero.");
                    }
                    break;
            }
        }

        public void Equals(decimal displayValue)
        {
            operand2 = displayValue;
            Equals();
        }

        public void Clear()
        {
            currentValue = 0;
            operand1 = 0;
            operand2 = 0;
            op = null;
        }
        internal class calculator
        {

        }
    }
}

