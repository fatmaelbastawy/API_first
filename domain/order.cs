using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain
{
    public class Order
    {
        public long ID { get; set; }

        public DateTime order_date { get; set; }

        //public IEnumerable<Product> products { get; set; }

        public IEnumerable<order_details> OrderDetails { get; set; }
        public Payment Payment { get; set; }

        public User User { get; set; }
    }
}
