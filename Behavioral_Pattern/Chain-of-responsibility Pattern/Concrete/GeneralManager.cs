using Behavioral_Pattern.Chain_of_responsibility_Pattern.Abstracts;
using Behavioral_Pattern.Chain_of_responsibility_Pattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Pattern.Chain_of_responsibility_Pattern.Concrete
{
    class GeneralManager : ManagerHandler
    {
        public GeneralManager(string name)
            : base(name) { }

        public override void RequstPersonLeave(LeaveRequest leaveRequest)
        {
            if (leaveRequest.Days <= 10)
            {
                Console.WriteLine($"{GetType().Name}：{_name}，已批准{leaveRequest.Name}，{leaveRequest.Days}天假");
            }
            else
            {
                Console.WriteLine($"{GetType().Name}：請太多天假了");
            }
        }
    }
}
