using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeaveManagement.Model
{
    public class LeaveTransaction
    {
        public TimeSpan Span;

        public int LeaveId;

        public int EmployeeId;

        public int AdminId;

        public LeaveStatus Status;

    }
}
