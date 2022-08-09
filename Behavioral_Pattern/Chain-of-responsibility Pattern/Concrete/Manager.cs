using Behavioral_Pattern.Chain_of_responsibility_Pattern.Abstracts;
using Behavioral_Pattern.Chain_of_responsibility_Pattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Pattern.Chain_of_responsibility_Pattern.Concrete
{
    class Manager : ManagerHandler
    {
        public Manager(string name)
            : base(name) { }

        public override void RequstPersonLeave(LeaveRequest leaveRequest)
        {
            if (leaveRequest.Days <= 2)
            {
                Console.WriteLine($"{GetType().Name}：{_name}，已批准{leaveRequest.Name}，{leaveRequest.Days}天假");
            }
            else
            {
                if (_supervisor != null)
                {
                    Console.WriteLine($"{GetType().Name}沒有權限批准，{leaveRequest.Days}天假");
                    _supervisor.RequstPersonLeave(leaveRequest);
                }
            }
        }
    }
}
