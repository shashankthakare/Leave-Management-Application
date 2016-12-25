using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement.Model
{
    public class Leave
    {


        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Reason
        {
            get { return _reason; }
            set { _reason = value; }
        }

        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        private int _id;
        private string _title;
        private string _reason;
        private string _category;

        public int Id
        {
            get { return _id; }
           
        }

        


        public Leave(int id, string title, string reason, string category)
        {
            _id = id;
            _title = title;
            _reason = reason;
            _category = category;
        }
    }
}
