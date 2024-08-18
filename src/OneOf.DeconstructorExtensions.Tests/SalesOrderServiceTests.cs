using NUnit.Framework;
using OneOf;
using System.Collections.Generic;
using OneOf.Deconstruct;

namespace OneOf.DeconstructorExtension.Tests
{
    public class SalesOrderServiceTests
    {
        private SalesOrderService svc = new SalesOrderService();

        [Test]
        public void TestCreateSalesOrderError1()
        {
            var createOrderDto = new SalesOrder();
            var (order, genericError, outOfStock) = svc.CreateSalesOrder(createOrderDto);
            Assert.That(order, Is.Null);
            Assert.That(outOfStock, Is.Null);
            Assert.That(genericError, Is.Not.Null);
            Assert.That(genericError!.Value.Value == "CustomerId is required");
        }

        [Test]
        public void TestCreateSalesOrderError2()
        {
            var createOrderDto = new SalesOrder() { CustomerId = 1 };

            var (order, genericError, outOfStock) = svc.CreateSalesOrder(createOrderDto);
            Assert.That(order, Is.Null);
            Assert.That(outOfStock, Is.Null);
            Assert.That(genericError, Is.Not.Null);
            Assert.That(genericError!.Value.Value == "Empty Order");
        }


        [Test]
        public void TestCreateSalesOrderOutOfStockError()
        {
            var createOrderDto = new SalesOrder() { CustomerId = 1, Items = new List<OrderItem>() { new OrderItem() { ProductSKU = 99, Quantity = 1 } } };

            var (order, genericError, outOfStock) = svc.CreateSalesOrder(createOrderDto);
            Assert.That(order, Is.Null);
            Assert.That(genericError, Is.Null);
            Assert.That(outOfStock, Is.Not.Null);
            Assert.That(outOfStock!.Value.Value.ProductSKU == 99);
        }

        [Test]
        public void TestCreateSalesOrderSuccess()
        {
            var createOrderDto = new SalesOrder() { CustomerId = 1, Items = new List<OrderItem>() { new OrderItem() { ProductSKU = 10, Quantity = 1 } } };

            var (order, genericError, outOfStock) = svc.CreateSalesOrder(createOrderDto);
            Assert.That(genericError, Is.Null);
            Assert.That(outOfStock, Is.Null);
            Assert.That(order, Is.Not.Null);
            Assert.That(order!.Value.Value.OrderId, Is.EqualTo(101));
        }
    }

}


