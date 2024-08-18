using NUnit.Framework;
using System;
using OneOf;
using System.Collections.Generic;

namespace OneOf.ToTupleExtensions.Tests
{
    public class SalesOrderServiceTests
    {
        private SalesOrderService svc = new SalesOrderService();

        [Test]
        public void TestCreateSalesOrderError1()
        {
            var createOrderDto = new SalesOrder();

            // Testing with ValueTuple
            var (order, genericError, outOfStock) = svc.CreateSalesOrder(createOrderDto).ToValueTuple();
            Assert.That(order, Is.Null);
            Assert.That(outOfStock, Is.Null);
            Assert.That(genericError, Is.Not.Null);
            Assert.That(genericError!.Value.Value == "CustomerId is required");

            // Testing with Tuple
            (order, genericError, outOfStock) = svc.CreateSalesOrder(createOrderDto).ToTuple();
            Assert.That(order, Is.Null);
            Assert.That(outOfStock, Is.Null);
            Assert.That(genericError, Is.Not.Null);
            Assert.That(genericError!.Value.Value == "CustomerId is required");
        }

        [Test]
        public void TestCreateSalesOrderError2()
        {
            var createOrderDto = new SalesOrder() { CustomerId = 1 };

            // Testing with ValueTuple
            var (order, genericError, outOfStock) = svc.CreateSalesOrder(createOrderDto).ToValueTuple();
            Assert.That(order, Is.Null);
            Assert.That(outOfStock, Is.Null);
            Assert.That(genericError, Is.Not.Null);
            Assert.That(genericError!.Value.Value == "Empty Order");

            // Testing with Tuple
            (order, genericError, outOfStock) = svc.CreateSalesOrder(createOrderDto).ToTuple();
            Assert.That(order, Is.Null);
            Assert.That(outOfStock, Is.Null);
            Assert.That(genericError, Is.Not.Null);
            Assert.That(genericError!.Value.Value == "Empty Order");
        }


        [Test]
        public void TestCreateSalesOrderOutOfStockError()
        {
            var createOrderDto = new SalesOrder() { CustomerId = 1, Items = new List<OrderItem>() { new OrderItem() { ProductSKU = 99, Quantity = 1 } } };

            // Testing with ValueTuple
            var (order, genericError, outOfStock) = svc.CreateSalesOrder(createOrderDto).ToValueTuple();
            Assert.That(order, Is.Null);
            Assert.That(genericError, Is.Null);
            Assert.That(outOfStock, Is.Not.Null);
            Assert.That(outOfStock!.Value.Value.ProductSKU == 99);

            // Testing with Tuple
            (order, genericError, outOfStock) = svc.CreateSalesOrder(createOrderDto).ToTuple();
            Assert.That(order, Is.Null);
            Assert.That(genericError, Is.Null);
            Assert.That(outOfStock, Is.Not.Null);
            Assert.That(outOfStock!.Value.Value.ProductSKU == 99);
        }

        [Test]
        public void TestCreateSalesOrderSuccess()
        {
            var createOrderDto = new SalesOrder() { CustomerId = 1, Items = new List<OrderItem>() { new OrderItem() { ProductSKU = 10, Quantity = 1 } } };

            // Testing with ValueTuple
            var (order, genericError, outOfStock) = svc.CreateSalesOrder(createOrderDto).ToValueTuple();
            Assert.That(genericError, Is.Null);
            Assert.That(outOfStock, Is.Null);
            Assert.That(order, Is.Not.Null);
            Assert.That(order!.Value.Value.OrderId, Is.EqualTo(101));

            // Testing with Tuple
            (order, genericError, outOfStock) = svc.CreateSalesOrder(createOrderDto).ToTuple();
            Assert.That(genericError, Is.Null);
            Assert.That(outOfStock, Is.Null);
            Assert.That(order, Is.Not.Null);
            Assert.That(order!.Value.Value.OrderId, Is.EqualTo(101));
        }
    }

}


