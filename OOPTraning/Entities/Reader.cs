using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTraning.Entities
{
    public class Reader : User
    {

        public Reader(string name, string surName, string userName, string password ) : base(name, surName, userName, password)
        {
        }
    }
}
