using Behavioral_Pattern.Chain_of_responsibility_Pattern.Models;
using Behavioral_Pattern.Chain_of_responsibility_Pattern.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Pattern.Chain_of_responsibility_Pattern
{
    class Chain_of_responsibility
    {
        /// <summary>
        /// 責任鏈模式 (Chain-of-responsibility Pattern)：有幾個物件都能處理某種請求，但處理的範圍(權限)不同，當這個物件沒有處理的權限時，能夠將這個請求，傳遞給下一個物件繼續處理。
        /// </summary>
        public void Go()
        {
            var manager_A = new Manager("AAA");

            var director_B = new Director("BBB");

            var generalManager_C = new GeneralManager("CCC");

            director_B.SetSupervisor(generalManager_C);

            manager_A.SetSupervisor(director_B);

            var leaveRequest_X = new LeaveRequest()
            {
                Name = "Employee_X",
                Days = 1
            };

            var leaveRequest_Y = new LeaveRequest()
            {
                Name = "Employee_Y",
                Days = 5
            };

            var leaveRequest_Z = new LeaveRequest()
            {
                Name = "Employee_Z",
                Days = 9
            };

            var leaveRequest_666 = new LeaveRequest()
            {
                Name = "Employee_666",
                Days = 666
            };

            manager_A.RequstPersonLeave(leaveRequest_X);
            manager_A.RequstPersonLeave(leaveRequest_Y);
            manager_A.RequstPersonLeave(leaveRequest_Z);
            manager_A.RequstPersonLeave(leaveRequest_666);
        }
    }
}
