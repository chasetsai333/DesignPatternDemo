using Behavioral_Pattern.Interpreter_Pattern.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Pattern.Interpreter_Pattern.Concretes
{
    class Expression_Zodiac_A:Expression
    {
        public override void Execute(int num)
        {
            string result = "";
            switch (num)
            {
                case 1:
                    result = "鼠";
                    break;
                case 2:
                    result = "牛";
                    break;
                case 3:
                    result = "虎";
                    break;
                case 4:
                    result = "兔";
                    break;
                case 5:
                    result = "龍";
                    break;
                case 6:
                    result = "蛇";
                    break;
                case 7:
                    result = "馬";
                    break;
                case 8:
                    result = "羊";
                    break;
                case 9:
                    result = "猴";
                    break;
                case 10:
                    result = "雞";
                    break;
                case 11:
                    result = "狗";
                    break;
                case 12:
                    result = "豬";
                    break;
            }

            Console.Write(result);
        }
    }
}
