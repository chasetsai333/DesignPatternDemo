using Behavioral_Pattern.Chain_of_responsibility_Pattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Pattern.Chain_of_responsibility_Pattern.Abstracts
{
    abstract class ManagerHandler
    {
        protected readonly string _name;
        protected ManagerHandler _supervisor;

        public ManagerHandler(string name)
        {
            _name = name;
        }

        public void SetSupervisor(ManagerHandler managerHandler)
        {
            _supervisor = managerHandler;
        }

        abstract public void RequstPersonLeave(LeaveRequest leaveRequest);
    }
}
