using OneOf;
using OneOf.Types;
using System.Linq;

namespace OneOf.ToTupleExtensions.Tests
{
    // For clearer semantics some developers prefer to wrap successful results under Success<T> wrapper and error results under Error<T>
    // The downside is that it's more verbose (to declare, to return, and also after decontruction you'll need to unwrap ".Value" twice

    public class SalesOrderService
    {
        /// <summary>
        /// CreateSalesOrder returns only one of these types (the others will be null): 
        /// - a successful result (a SalesOrder object wrapped under a Success{T})
        /// - one error string that should just be displayed to the end-user
        /// - a few discriminated errors that should be handled individually by the caller
        /// </summary>
        public OneOf<Success<SalesOrder>, Error<string>, Error<OutOfStockError>> CreateSalesOrder(SalesOrder order)
        {
            // Errors that should just be displayed to the end-user
            if (order.CustomerId == 0)
                return new Error<string>($"{nameof(order.CustomerId)} is required");

            if (order.Items == null || order.Items.Count == 0)
                return new Error<string>($"Empty Order");

            var invalidQty = order.Items.Where(i => i.Quantity <= 0).FirstOrDefault();
            if (invalidQty != null)
                return new Error<string>($"Invalid quantity for Product SKU {invalidQty.ProductSKU}");

            var outOfStock = order.Items.Where(i => i.ProductSKU == 99).FirstOrDefault();
            if (outOfStock != null)
            {
                // Caller will also show this to user, but might/should also take other actions like put a backorder to the vendor
                return new Error<OutOfStockError>(new OutOfStockError(outOfStock.ProductSKU));
            }

            // Success
            order.OrderId = 101;
            return new Success<SalesOrder>(order);
        }

        public class OutOfStockError
        {
            public int ProductSKU { get; set; }
            public OutOfStockError(int productSKU) 
            {
                ProductSKU = productSKU;
            }
        }

    }
}

