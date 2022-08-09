using Creational_Pattern.BuilderPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_Pattern.BuilderPattern
{
    class Director
    {
        private readonly IBuilder _builder;
        public Director(IBuilder builder)
        {
            _builder = builder;
        }

        public void Create() 
        {
            _builder.Cup();
            _builder.Fill();
            _builder.Cover();
            _builder.Straw();
        }
    }
}
