using NUnit.Framework;
using System;
using OneOf;
using OneOf.Types;

namespace OneOf.DeconstructorExtension.Tests
{
    public class DeconstructTests
    {
        [Test]
        public void TestDescontruct1()
        {
            var (a, b, c) = OneOf<int, int, int>.FromT0(1);
            Assert.That(a, Is.Not.Null);
            Assert.That(b, Is.Null);
            Assert.That(c, Is.Null);

            (a, b, c) = OneOf<int, int, int>.FromT2(1);
            Assert.That(a, Is.Null);
            Assert.That(b, Is.Null);
            Assert.That(c, Is.Not.Null);
        }

        [Test]
        public void TestDescontruct2()
        {
            var (a, b, c) = OneOf<int, string, int>.FromT1("test");
            Assert.That(a, Is.Null);
            Assert.That(b, Is.Not.Null);
            Assert.That(c, Is.Null);
        }


        [Test]
        public void TestDescontruct3()
        {
            var (a, b, c) = OneOf<SalesOrder, SalesOrderService.OutOfStockError, Error<string>>.FromT0(new SalesOrder());
            Assert.That(a, Is.Not.Null);
            Assert.That(b, Is.Null);
            Assert.That(c, Is.Null);

            (a, b, c) = OneOf<SalesOrder, SalesOrderService.OutOfStockError, Error<string>>.FromT1(new SalesOrderService.OutOfStockError(1));
            Assert.That(a, Is.Null);
            Assert.That(b, Is.Not.Null);
            Assert.That(c, Is.Null);

            (a, b, c) = OneOf<SalesOrder, SalesOrderService.OutOfStockError, Error<string>>.FromT2(new Error<string>("Generic Error"));
            Assert.That(a, Is.Null);
            Assert.That(b, Is.Null);
            Assert.That(c, Is.Not.Null);
        }

    }

}


