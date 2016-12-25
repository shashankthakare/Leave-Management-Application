using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeaveManagement.Contracts
{
    interface IEmployeeScreen
    {
        void CreateApplication(LeaveManagement.Model.Leave leave);
        
        List<LeaveManagement.Model.Leave> ViewAllApplications(LeaveManagement.Model.Employee employee, LeaveManagement.Model.LeaveSearchCriterion criterion);

        List<LeaveManagement.Model.Leave> ViewOld(LeaveManagement.Model.LeaveSearchCriterion criterion);

        void ReportingTo(LeaveManagement.Model.Employee employee);

        void ListApplicationsOfPeopleUnderMe(LeaveManagement.Model.Employee employee);
    }
}
