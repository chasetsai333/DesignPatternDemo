using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_Pattern.BuilderPattern.Interface
{
    interface IBuilder
    {
        void Cup();

        void Fill();

        void Cover();

        void Straw();
    }
}
