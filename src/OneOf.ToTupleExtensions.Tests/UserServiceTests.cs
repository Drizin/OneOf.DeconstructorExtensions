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
        public void TestDeleteUserSuccessValueTuple()
        {
            var (success, error) = svc.DeleteUser(username: "Rick").ToValueTuple();
            Assert.That(success, Is.Not.Null);
            Assert.That(error, Is.Null);
        }
        [Test]
        public void TestDeleteUserSuccessTuple()
        {
            var (success, error) = svc.DeleteUser(username: "Rick").ToTuple();
            Assert.That(success, Is.Not.Null);
            Assert.That(error, Is.Null);
        }

        [Test]
        public void TestDeleteUserErrorValueTuple()
        {
            var (success, error) = svc.DeleteUser(username: "John").ToValueTuple();
            Assert.That(success, Is.Null);
            Assert.That(error, Is.Not.Null);
        }
        [Test]
        public void TestDeleteUserErrorTuple()
        {
            var (success, error) = svc.DeleteUser(username: "John").ToTuple();
            Assert.That(success, Is.Null);
            Assert.That(error, Is.Not.Null);
        }


        [Test]
        public void TestCreateUserSuccessValueTuple()
        {
            var command = new UserService.CreateUserDTO() { FirstName = "Rick", LastName = "Drizin", UserName = "drizin", Password = "12345678" };
            var (user, error, validationErrors) = svc.CreateUser(command).ToValueTuple();
            Assert.That(user, Is.Not.Null);
            Assert.That(error, Is.Null);
            Assert.That(validationErrors, Is.Null);

            // The whole idea of converting OneOf<> to Tuple is to enable deconstructing in a single golang-like statement
            // But if you don't want to deconstruct the tuple, ValueTuple items are currently named as T0/T1/etc (instead of Item1/Item2/etc) so they match the 0-based-index OneOf types
            var tuple = svc.CreateUser(command).ToValueTuple();
            Assert.That(tuple.T0!.UserName, Is.EqualTo(user!.UserName));
            Assert.That(tuple.T0!.GetType(), Is.EqualTo(typeof(User)));
        }

        [Test]
        public void TestCreateUserSuccessTuple()
        {
            var command = new UserService.CreateUserDTO() { FirstName = "Rick", LastName = "Drizin", UserName = "drizin", Password = "12345678" };
            var (user, error, validationErrors) = svc.CreateUser(command).ToTuple();
            Assert.That(user, Is.Not.Null);
            Assert.That(error, Is.Null);
            Assert.That(validationErrors, Is.Null);
        }


        [Test]
        public void TestCreateUserErrorValueTuple()
        {
            var command = new UserService.CreateUserDTO() { UserName = "Rick" };
            var (user, error, validationErrors) = svc.CreateUser(command).ToValueTuple();
            Assert.That(user, Is.Null);
            Assert.That(error, Is.Not.Null);
            Assert.That(error, Is.EqualTo(UserService.CreateUserErrorEnum.USERNAME_NOT_AVAILABLE));
            Assert.That(validationErrors, Is.Null);

            // The whole idea of converting OneOf<> to Tuple is to enable deconstructing in a single golang-like statement
            // But if you don't want to deconstruct the tuple, ValueTuple items are currently named as T0/T1/etc (instead of Item1/Item2/etc) so they match the 0-based-index OneOf types
            var tuple = svc.CreateUser(command).ToValueTuple();
            Assert.That(tuple.T1, Is.EqualTo(error));
            Assert.That(tuple.T1!.GetType(), Is.EqualTo(typeof(UserService.CreateUserErrorEnum)));
        }
        [Test]
        public void TestCreateUserErrorTuple()
        {
            var command = new UserService.CreateUserDTO() { UserName = "Rick" };
            var (user, error, validationErrors) = svc.CreateUser(command).ToTuple();
            Assert.That(user, Is.Null);
            Assert.That(error, Is.Not.Null);
            Assert.That(error, Is.EqualTo(UserService.CreateUserErrorEnum.USERNAME_NOT_AVAILABLE));
            Assert.That(validationErrors, Is.Null);
        }


        [Test]
        public void TestCreateUserError2ValueTuple()
        {
            var (user, error, validationErrors) = svc.CreateUser(new UserService.CreateUserDTO() { UserName = "Rick2", Password = "short" }).ToValueTuple();
            Assert.That(user, Is.Null);
            Assert.That(error, Is.Not.Null);
            Assert.That(error, Is.EqualTo(UserService.CreateUserErrorEnum.WEAK_PASSWORD));
            Assert.That(validationErrors, Is.Null);
        }
        [Test]
        public void TestCreateUserError2Tuple()
        {
            var (user, error, validationErrors) = svc.CreateUser(new UserService.CreateUserDTO() { UserName = "Rick2", Password = "short" }).ToTuple();
            Assert.That(user, Is.Null);
            Assert.That(error, Is.Not.Null);
            Assert.That(error, Is.EqualTo(UserService.CreateUserErrorEnum.WEAK_PASSWORD));
            Assert.That(validationErrors, Is.Null);
        }

        [Test]
        public void TestValidationErrorsValueTuple()
        {
            var command = new UserService.CreateUserDTO() { FirstName = "Rick", LastName = "Drizin" };
            var (user, error, validationErrors) = svc.CreateUser(command).ToValueTuple();
            Assert.That(user, Is.Null);
            Assert.That(error, Is.Null);
            Assert.That(validationErrors, Is.Not.Null);
            Assert.That(validationErrors!.Any(e => e.Message == "UserName is required"));

            // The whole idea of converting OneOf<> to Tuple is to enable deconstructing in a single golang-like statement
            // But if you don't want to deconstruct the tuple, ValueTuple items are currently named as T0/T1/etc (instead of Item1/Item2/etc) so they match the 0-based-index OneOf types
            var tuple = svc.CreateUser(command).ToValueTuple();
            Assert.That(tuple.T2!.First().Message, Is.EqualTo(validationErrors!.First().Message));
            Assert.That(tuple.T2!.GetType(), Is.EqualTo(typeof(List<ValidationError>)));
        }
        [Test]
        public void TestValidationErrorsTuple()
        {
            var command = new UserService.CreateUserDTO() { FirstName = "Rick", LastName = "Drizin" };
            var (user, error, validationErrors) = svc.CreateUser(command).ToTuple();
            Assert.That(user, Is.Null);
            Assert.That(error, Is.Null);
            Assert.That(validationErrors, Is.Not.Null);
            Assert.That(validationErrors!.Any(e => e.Message == "UserName is required"));
        }

        [Test]
        public void Playground()
        {
            var createUserCommand = new UserService.CreateUserDTO() { FirstName = "Rick", LastName = "Drizin", UserName = "drizin", Password = "12345678" };

            // If you want to combine out deconstruct-syntax with the powerful OneOf Match() and Switch() methods
            // (which will enforce compile-time coverage of all types), you can do it:

            var oneOf = svc.CreateUser(createUserCommand);
            var (user, error, validationErrors) = oneOf.ToValueTuple();
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


