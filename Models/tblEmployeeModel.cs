using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_MVC_Demo_100524.Models
{
    public class tblEmployeeModel
    {
        public int id { get; set; }
        public string empName { get; set; }
        public string dept { get; set; }
        public Nullable<int> Salary { get; set; }
    }
}