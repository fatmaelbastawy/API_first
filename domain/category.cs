using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain
{
    public class Category
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public IEnumerable<Product> Products { get; set; }

        public Category Parent_Category { get; set; }

        public IEnumerable<Category>? Sub_Categories { get; set; }


    }
}
