using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_Pattern.PrototypePattern
{
    class Prototype
    {
        /// <summary>
        /// 原型模式 (Prototype Pattern)。用原型實例指定建立物件的種類，並透過拷貝這些原型建立新的物件。(ICloneable)
        /// </summary>
        public void Go()
        {
            Console.WriteLine("淺複製(shallow clone)：僅複製舊物件內的屬性，舊物件內的物件不複製。所以新、舊物件會共用這些其他物件。");
            Console.WriteLine("深複製(deep clone)：舊物件內的屬性、參考到的其他物件，都會複製一份。");
        }
    }
}
