using NUnit.Framework;
using System;
using OneOf;
using System.Linq;
using System.Collections.Generic;

namespace OneOf.ToTupleExtensions.Tests
{
    public class UserServiceTests
    {
        private UserService svc = new UserService();

        [Test]
        public void TestDeleteUserSuccess()
        {
            // Testing with ValueTuple
            var (success, error) = svc.DeleteUser(username: "Rick").ToValueTuple();
            Assert.That(success, Is.Not.Null);
            Assert.That(error, Is.Null);

            // Testing with Tuple
            (success, error) = svc.DeleteUser(username: "Rick").ToTuple();
            Assert.That(success, Is.Not.Null);
            Assert.That(error, Is.Null);
        }

        [Test]
        public void TestDeleteUserError()
        {
            // Testing with ValueTuple
            var (success, error) = svc.DeleteUser(username: "John").ToValueTuple();
            Assert.That(success, Is.Null);
            Assert.That(error, Is.Not.Null);

            // Testing with Tuple
            (success, error) = svc.DeleteUser(username: "John").ToTuple();
            Assert.That(success, Is.Null);
            Assert.That(error, Is.Not.Null);
        }


        [Test]
        public void TestCreateUserSuccess()
        {
            // Testing with ValueTuple
            var (user, error, validationErrors) = svc.CreateUser(new UserService.CreateUserDTO() { FirstName = "Rick", LastName = "Drizin", UserName = "drizin", Password = "12345678" }).ToValueTuple();
            Assert.That(user, Is.Not.Null);
            Assert.That(error, Is.Null);
            Assert.That(validationErrors, Is.Null);

            // Testing with Tuple
            (user, error, validationErrors) = svc.CreateUser(new UserService.CreateUserDTO() { FirstName = "Rick", LastName = "Drizin", UserName = "drizin", Password = "12345678" }).ToTuple();
            Assert.That(user, Is.Not.Null);
            Assert.That(error, Is.Null);
            Assert.That(validationErrors, Is.Null);
        }


        [Test]
        public void TestCreateUserError()
        {
            // Testing with ValueTuple
            var (user, error, validationErrors) = svc.CreateUser(new UserService.CreateUserDTO() { UserName = "Rick" }).ToValueTuple();
            Assert.That(user, Is.Null);
            Assert.That(error, Is.Not.Null);
            Assert.That(error, Is.EqualTo(UserService.CreateUserErrorEnum.USERNAME_NOT_AVAILABLE));
            Assert.That(validationErrors, Is.Null);

            // Testing with Tuple
            (user, error, validationErrors) = svc.CreateUser(new UserService.CreateUserDTO() { UserName = "Rick" }).ToTuple();
            Assert.That(user, Is.Null);
            Assert.That(error, Is.Not.Null);
            Assert.That(error, Is.EqualTo(UserService.CreateUserErrorEnum.USERNAME_NOT_AVAILABLE));
            Assert.That(validationErrors, Is.Null);
        }

        [Test]
        public void TestCreateUserError2()
        {
            // Testing with ValueTuple
            var (user, error, validationErrors) = svc.CreateUser(new UserService.CreateUserDTO() { UserName = "Rick2", Password = "short" }).ToValueTuple();
            Assert.That(user, Is.Null);
            Assert.That(error, Is.Not.Null);
            Assert.That(error, Is.EqualTo(UserService.CreateUserErrorEnum.WEAK_PASSWORD));
            Assert.That(validationErrors, Is.Null);

            // Testing with Tuple
            (user, error, validationErrors) = svc.CreateUser(new UserService.CreateUserDTO() { UserName = "Rick2", Password = "short" }).ToTuple();
            Assert.That(user, Is.Null);
            Assert.That(error, Is.Not.Null);
            Assert.That(error, Is.EqualTo(UserService.CreateUserErrorEnum.WEAK_PASSWORD));
            Assert.That(validationErrors, Is.Null);
        }

        [Test]
        public void TestValidationErrors()
        {
            // Testing with ValueTuple
            var (user, error, validationErrors) = svc.CreateUser(new UserService.CreateUserDTO() { FirstName = "Rick", LastName = "Drizin" }).ToValueTuple();
            Assert.That(user, Is.Null);
            Assert.That(error, Is.Null);
            Assert.That(validationErrors, Is.Not.Null);
            Assert.That(validationErrors.Any(e => e.Message == "UserName is required"));

            // Testing with Tuple
            (user, error, validationErrors) = svc.CreateUser(new UserService.CreateUserDTO() { FirstName = "Rick", LastName = "Drizin" }).ToTuple();
            Assert.That(user, Is.Null);
            Assert.That(error, Is.Null);
            Assert.That(validationErrors, Is.Not.Null);
            Assert.That(validationErrors.Any(e => e.Message == "UserName is required"));
        }

        [Test]
        public void TestNamedTuple()
        {
            var createUserCommand = new UserService.CreateUserDTO() { FirstName = "Rick", LastName = "Drizin", UserName = "drizin", Password = "12345678" };

            // The whole idea of converting OneOf<> to Tuple is to enable deconstructing in a single golang-like statement like this:
            //var (user, error, validationErrors) = svc.CreateUser(createUserCommand).ToValueTuple();
            // BUT if you don't want to deconstruct the tuple, ValueTuple items are currently named as T0/T1/etc instead of Item1/Item2/etc,
            // so they match OneOf 0-based indexes
            var tuple = svc.CreateUser(createUserCommand).ToValueTuple();
            var (user, error, validationErrors) = tuple;

            Assert.That(tuple.T0, Is.EqualTo(user));
            Assert.That(tuple.T0.GetType(), Is.EqualTo(typeof(User)));
            Assert.That(tuple.T1, Is.Null); // typeof(Nullable<UserService.CreateUserErrorEnum>)
            Assert.That(tuple.T2, Is.Null); // typeof(List<ValidationError>)

            // AND if you want to combine out deconstruct-syntax with the powerful OneOf Match() and Switch() methods
            // (which will enforce compile-time coverage of all types), you can do it:

            var oneOf = svc.CreateUser(createUserCommand);
            (user, error, validationErrors) = oneOf.ToValueTuple();
            if (validationErrors != null) 
            {
                // SHOW message to user
                return; // early return
            }

            oneOf.Switch(
                user => {
                    // This is what I care most
                    // If any new type is added to OneOf this method will break and we'll have to explicitly handle the new type
                },
                errorEnum => {
                    // caller should handle these errors
                    // If we want to fully use the power of discriminated-union-types then each error should be a different type
                    // (and get it's own lambda handler)
                    // instead of using enums
                },
                validationErrors => {
                    // I can ignore this at this point since I've used ValueTuple deconstruction to test this and early-return
                });
        }


    }

}


