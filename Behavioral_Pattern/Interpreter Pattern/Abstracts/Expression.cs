using Behavioral_Pattern.Interpreter_Pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Behavioral_Pattern.Interpreter_Pattern.Abstracts
{
    abstract class Expression
    {
        public void Interpret(Context context)
        {
            if (context.Text.Length > 0)
            {
                if (context.Text.Length > 0)
                {
                    int spacePos = context.Text.IndexOf(",");
                    string word = "";
                    if (spacePos != -1)
                    {
                        word = context.Text.Substring(0, spacePos);
                        context.Text = context.Text.Substring(spacePos + 1);

                    }
                    else
                    {
                        word = context.Text;
                        context.Text = "";
                    }

                    int num = (Convert.ToInt32(word.Substring(1)) + 9) % 12;
                    if (0 == num)
                    {
                        num = 12;
                    }
                    Execute(num);
                }
            }
        }

        public abstract void Execute(int num);
    }
}
