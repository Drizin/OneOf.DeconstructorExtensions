using NUnit.Framework;
using OneOf;
using System.Linq;
using OneOf.Deconstruct;

namespace OneOf.DeconstructorExtension.Tests
{
    public class UserServiceTests
    {
        private UserService svc = new UserService();

        [Test]
        public void TestDeleteUserSuccess()
        {
            var (success, error) = svc.DeleteUser(username: "Rick");
            Assert.That(success, Is.Not.Null);
            Assert.That(error, Is.Null);
        }
        [Test]
        public void TestDeleteUserSuccessTuple()
        {
            var (success, error) = svc.DeleteUser(username: "Rick");
            Assert.That(success, Is.Not.Null);
            Assert.That(error, Is.Null);
        }

        [Test]
        public void TestDeleteUserError()
        {
            var (success, error) = svc.DeleteUser(username: "John");
            Assert.That(success, Is.Null);
            Assert.That(error, Is.Not.Null);
        }
        [Test]
        public void TestDeleteUserErrorTuple()
        {
            var (success, error) = svc.DeleteUser(username: "John");
            Assert.That(success, Is.Null);
            Assert.That(error, Is.Not.Null);
        }


        [Test]
        public void TestCreateUserSuccess()
        {
            var command = new UserService.CreateUserDTO() { FirstName = "Rick", LastName = "Drizin", UserName = "drizin", Password = "12345678" };
            var (user, error, validationErrors) = svc.CreateUser(command);
            Assert.That(user, Is.Not.Null);
            Assert.That(error, Is.Null);
            Assert.That(validationErrors, Is.Null);
        }

        [Test]
        public void TestCreateUserError()
        {
            var command = new UserService.CreateUserDTO() { UserName = "Rick" };
            var (user, error, validationErrors) = svc.CreateUser(command);
            Assert.That(user, Is.Null);
            Assert.That(error, Is.Not.Null);
            Assert.That(error, Is.EqualTo(UserService.CreateUserErrorEnum.USERNAME_NOT_AVAILABLE));
            Assert.That(validationErrors, Is.Null);
        }


        [Test]
        public void TestCreateUserError2()
        {
            var (user, error, validationErrors) = svc.CreateUser(new UserService.CreateUserDTO() { UserName = "Rick2", Password = "short" });
            Assert.That(user, Is.Null);
            Assert.That(error, Is.Not.Null);
            Assert.That(error, Is.EqualTo(UserService.CreateUserErrorEnum.WEAK_PASSWORD));
            Assert.That(validationErrors, Is.Null);
        }

        [Test]
        public void TestValidationErrors()
        {
            var command = new UserService.CreateUserDTO() { FirstName = "Rick", LastName = "Drizin" };
            var (user, error, validationErrors) = svc.CreateUser(command);
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
            var (user, error, validationErrors) = oneOf;
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


