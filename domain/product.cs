namespace domain
{
    public class Product
    {
        public long ID { get; set; }

        public string Name { get; set; }

        public string features { get; set; }

        public float Price { get; set; }

        public IEnumerable<Category> Categories { get; set; }

        public IEnumerable<order_details> Order_Details { get; set; }

        //public IEnumerable<Order> Orders { get; set; }
    }

    
}