using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_Pattern.SingletonPattern
{
    public sealed class EagerInitialization
    {
        private static readonly EagerInitialization _instance = new EagerInitialization();

        public int Number = 1;

        private EagerInitialization() { }

        public static EagerInitialization GetInstance()
        {
            return _instance;
        }
    }
}
