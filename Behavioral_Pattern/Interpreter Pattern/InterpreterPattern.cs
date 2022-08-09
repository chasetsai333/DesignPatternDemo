using Behavioral_Pattern.Interpreter_Pattern.Abstracts;
using Behavioral_Pattern.Interpreter_Pattern.Concretes;
using Behavioral_Pattern.Interpreter_Pattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Pattern.Interpreter_Pattern
{
    class InterpreterPattern
    {
        /// <summary>
        /// 解釋器模式 (Interpreter Pattern)：用來解釋、直譯一種語言的方法。
        /// </summary>
        public void Go()
        {
            var context = new Context() { Text = "a2015,b2015,a2021,b2021" };

            Expression expression = null;

            while (context.Text.Length > 0)
            {
                switch (context.Text.Substring(0, 1))
                {
                    case "a":
                        expression = new Expression_Zodiac_A(); // 生肖
                        break;
                    case "b":
                        expression = new Expression_Zodiac_B(); // 地支
                        break;
                }

                expression.Interpret(context);
            }
        }
    }
}
