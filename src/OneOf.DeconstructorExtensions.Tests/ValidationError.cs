namespace OneOf.DeconstructorExtension.Tests
{
    /// <summary>
    /// Validation errors are just informative errors that should only be displayed to the UI user, as opposed to having the caller-method take some action (error-handling) based upon these errors.
    /// By having a specific type for these errors (which your code should just pass-through the UI instead of explicitly handling) 
    /// we can have a different return property to be used for the "real errors that require programmatic error-handling".
    /// 
    /// Validation errors are usually based on user-input (so they are usually associated to a (<see cref="PropertyName"/>) of some object)
    /// and usually these validations happen earlier in the method, leaving the "real errors that require programmatic error-handling" to be returned later.
    /// So they are used in conjunction with the OneOf tuples that include a possible success and (if the caller should handle errors) a possible enum of errors (or discriminated types)
    /// </summary>
    public class ValidationError
    {

        /// <summary>
        /// Message of the error
        /// </summary>
        public string Message { get; protected set; }

        /// <summary>
        /// Property where error happened
        /// </summary>
        public string? PropertyName { get; protected set; }


        /// <inheritdoc />
        /// <param name="message">The validation error message</param>
        /// <param name="propertyName">The property where error happened</param>
        public ValidationError(string message, string propertyName)
        {
            Message = message;
            PropertyName = propertyName;
        }

        /// <summary>
        /// Initialize a new instance with a custom message and an exception
        /// </summary>
        /// <param name="message">The validation error message</param>
        public ValidationError(string message)
        {
            Message = message;
            PropertyName = null;
        }
    }

}

