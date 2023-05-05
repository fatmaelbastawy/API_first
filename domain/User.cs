using domain.@enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain
{
    public class User
    {
        public int ID { get; set; }

        public string F_Name { get; set; }

        public string L_Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Address { get; set; }

        public gender genger { get; set; }

        public IEnumerable<Order> Orders { get; set; }
    }
}
