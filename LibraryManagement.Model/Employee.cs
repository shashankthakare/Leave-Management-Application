using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement.Model
{
    public class Employee : User
    {
        

        public DateTime JoiningDate
        {
            get { return _joiningDate; }
            set { _joiningDate = value; }
        }

       

        public UserType EmployeeType
        {
            get { return _employeeType; }
            set { _employeeType = value; }
        }

        private DateTime _joiningDate;
      
        private UserType _employeeType;


       


    }

    
}
