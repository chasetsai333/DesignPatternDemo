using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Pattern.Proxy_Pattern
{
    class Proxy
    {
        /// <summary>
        /// 代理模式 (Proxy Pattern)：有兩個物件，代理物件、真實物件，系統使用代理物件操作，代理物件內部則再去操作真實物件。應用：遠程代理、虛擬代理、安全代理
        /// </summary>
        public void Go()
        {
            Console.WriteLine();
        }
    }
}
