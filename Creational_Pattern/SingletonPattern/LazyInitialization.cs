using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_Pattern.SingletonPattern
{
    class LazyInitialization
    {
        private static readonly object _thisLock = new object();

        private static LazyInitialization _instance;

        public int Number = 1;

        private LazyInitialization() { }

        public static LazyInitialization GetInstance() 
        {
            if (_instance == null)
            {
                lock (_thisLock)
                {
                    if (_instance == null)
                    {
                        _instance = new LazyInitialization();
                    }
                }
            }
            return _instance;
        }
    }
}
