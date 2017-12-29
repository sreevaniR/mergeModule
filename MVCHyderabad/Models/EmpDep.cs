using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCHyderabad.Models
{
    public class EmpDep
    {
         Employee e1=new Employee();
        public string FirstName
        {
            get
            {
                return e1.FirstName;
            }
            set
            {
                e1.FirstName = value;
            }
        }
        public string SecondName
        {
            get
            {
                return e1.SecondName;
            }
            set
            {
                e1.SecondName = value;
            }
        }

         Department d1=new Department();
        public string DeptName
        {
            get
            {
                return d1.DeptName;
            }
            set

            {
                d1.DeptName = value;
            }

        }
    }
}