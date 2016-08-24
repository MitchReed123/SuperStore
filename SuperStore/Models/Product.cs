using System.Collections.Generic;

namespace SuperStore.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Sku { get; set; }
        public int Inventory { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}