using OneOf;
using OneOf.Types;
using System.Collections.Generic;
using System.ComponentModel;

namespace OneOf.DeconstructorExtension.Tests
{
    public class UserService
    {
        /// <summary>
        /// DeleteUser returns only one of these types (the others will be null): 
        /// - a generic successful result (no underlying value)
        /// - a generic error
        /// </summary>
        public OneOf<Success, Error> DeleteUser(string username)
        {
            if (username == "Rick")
                return new Success();
            return new Error();
        }

        /// <summary>
        /// CreateUser returns only one of these types (the others will be null): 
        /// - a successful result (a User object)
        /// - an error (of enum type) 
        /// - one-or-more validation errors
        /// </summary>
        public OneOf<User, CreateUserErrorEnum, List<ValidationError>> CreateUser(CreateUserDTO newUserInfo)
        {
            // Validation errors should be the first ones to be tested and early return
            // I model them as "ValidationErrors" because the caller just pass those errors back to the UI, doesn't act upon them
            if (string.IsNullOrEmpty(newUserInfo?.UserName))
                return new List<ValidationError>() { new ValidationError($"{nameof(newUserInfo.UserName)} is required") };

            // Non-Validation errors are errors that might require the caller to act based on the errors
            // (in this bad example there's not much to do other than pass the message to the user, but you get the idea - caller could SWITCH upon the enum and act)
            if (newUserInfo!.UserName == "Rick")
                return CreateUserErrorEnum.USERNAME_NOT_AVAILABLE;
            if (string.IsNullOrEmpty(newUserInfo.Password) || newUserInfo.Password.Length < 8)
                return CreateUserErrorEnum.WEAK_PASSWORD;

            // Early returns reduce the need for nested ifs. If everything went fine we return the resulting object
            var user = new User() { FirstName = newUserInfo.FirstName, LastName = newUserInfo.LastName, UserName = newUserInfo.UserName };
            return user;
        }


        public enum CreateUserErrorEnum
        {
            [Description("Username not available")]
            USERNAME_NOT_AVAILABLE,

            [Description("Password not strong enough")]
            WEAK_PASSWORD,
        }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public class CreateUserDTO
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
        }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

    }

}

