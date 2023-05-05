using domain.@enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain
{
    public class Payment
    {
        public int ID { get; set; }

        public float Total_Amount { get; set; }

        public DateTime Payment_Date { get; set; }

        public payment_method Payment_Method { get; set; }

        public Order Order { get; set; }

        

       


    }
}
