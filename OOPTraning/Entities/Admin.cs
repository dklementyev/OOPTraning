using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTraning.Entities
{
    public class Admin : User
    {
        public decimal Salary{ get; set; }
        public Admin(string name, string surName, string userName, string password, decimal salary) : base(name, surName, userName, password)
        {
            Salary = salary;
        }
    }
}
