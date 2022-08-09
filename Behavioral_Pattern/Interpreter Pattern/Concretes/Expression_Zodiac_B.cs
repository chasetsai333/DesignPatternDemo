using Behavioral_Pattern.Interpreter_Pattern.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Pattern.Interpreter_Pattern.Concretes
{
    class Expression_Zodiac_B : Expression
    {
        public override void Execute(int num)
        {
            string result = "";
            switch (num)
            {
                case 1:
                    result = "子";
                    break;
                case 2:
                    result = "丑";
                    break;
                case 3:
                    result = "寅";
                    break;
                case 4:
                    result = "卯";
                    break;
                case 5:
                    result = "辰";
                    break;
                case 6:
                    result = "巳";
                    break;
                case 7:
                    result = "午";
                    break;
                case 8:
                    result = "未";
                    break;
                case 9:
                    result = "申";
                    break;
                case 10:
                    result = "酉";
                    break;
                case 11:
                    result = "戌";
                    break;
                case 12:
                    result = "亥";
                    break;
            }

            Console.Write(result);
        }
    }
}
