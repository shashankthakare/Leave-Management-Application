using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeaveManagement.Model;

namespace LeaveManagement.Contracts
{
    interface IAdminScreen
    {
        

        void AddUser(Admin admin, Employee employee);

        void EditUser(Admin admin, Employee employee);

        List<Employee> ViewAllEmployees(Admin admin, LeaveSearchCriterion criterion);


        






    }
}
