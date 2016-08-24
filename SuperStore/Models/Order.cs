using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SuperStore.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [DataType(DataType.Currency)]
        public decimal Total { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }

        [Display(Name = "Purchased (UTC)")]
        [DataType(DataType.DateTime)]
        public DateTimeOffset DatePurchasedUtc { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Customer Customer { get; set; }
    }
}