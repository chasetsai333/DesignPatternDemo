using Behavioral_Pattern.Command_Pattern;
using Behavioral_Pattern.Interpreter_Pattern;
using Behavioral_Pattern.Iterator_Pattern;
using Behavioral_Pattern.Strategy_Pattern;
using System;

namespace Behavioral_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Chain_of_responsibility_Pattern.Chain_of_responsibility().Go();

            new CommandPattern().Go();

            //new InterpreterPattern().Go();

            //new IteratorPattern().Go();

            //new StrategyPattern().Go();
        }
    }
}
