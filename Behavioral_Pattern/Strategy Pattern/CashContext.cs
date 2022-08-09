using Behavioral_Pattern.Strategy_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Pattern.Strategy_Pattern
{
    class CashContext
    {
        private IStrategy _strategy;

        public CashContext(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ExecuteStrategy(int money)
        {
            _strategy.Execute(money);
        }
    }
}
