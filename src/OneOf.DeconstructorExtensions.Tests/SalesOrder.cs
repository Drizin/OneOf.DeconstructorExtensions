#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System.Collections.Generic;

namespace OneOf.DeconstructorExtension.Tests
{
    public class SalesOrder
    {
        public int OrderId { get; set; }
        public decimal TotalPrice { get; set; }
        public int CustomerId { get; set; }
        public List<OrderItem> Items { get; set; }
    }

    public class OrderItem
    {
        public int ProductSKU { get; set; }
        public int Quantity { get; set; }
    }
}

#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
