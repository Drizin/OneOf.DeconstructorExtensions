[![Nuget](https://img.shields.io/nuget/v/OneOf.ToTupleExtensions?label=OneOf.ToTupleExtensions)](https://www.nuget.org/packages/OneOf.ToTupleExtensions)
[![Downloads](https://img.shields.io/nuget/dt/OneOf.ToTupleExtensions.svg)](https://www.nuget.org/packages/OneOf.ToTupleExtensions)

# OneOf

[OneOf](https://github.com/mcintyre321/OneOf/) is a popular library that enhances C# with discriminated unions, which basically means that you can create types that can represent different types - e.g. an instance of  `OneOf<int, string, float>` will hold a single value that will either be an `int`, or a `string`, or a `float`.

Discriminated unions are a great way to do exhaustive type matching, which means that the compiler can enforce that all possible types are being handled:
- By using `OneOf<>.Switch()` you **need** to specify an an `Action<T>` for each of possible type `T`, which means that the compiler will enforce that all possible types are handled
- By using `OneOf<>.Match()` you **need** to specify a `Func<T, TResult>` that will convert each possible type `T` into a single type `TResult`, which means that  the compiler will enforce that all possible types are handled

`OneOf` library intentionally does NOT allow the underlying types to be deconstructed because it kind of [defeats the purpose](https://github.com/mcintyre321/OneOf/pull/114) of the library, which is exactly to enforce compile-time exhaustive type matching.

However, in some cases it might be helpful to **deconstruct** the OneOf object into its underlying types...

# OneOf.ToTupleExtensions

**This library extends `OneOf<>` and `OneOfBase<>` with methods to convert them into `Tuple<>` or `ValueTuple<>`**, which have methods to deconstruct into the underlying types.

The major problem solved by this library is that **deconstruction is not trivial because of non-nullable value types**.

Let's say you have an instance of `OneOf<T0, T1, T2>` which is currently holding a value of type `T1`.  
If you deconstruct this into the underlying types `T0`, `T1` and `T2` you would expect that only `T0` has a non-null value.  
However, for example, if `T1` is a non-nullable type (like a struct or an enum) then we would need to convert `OneOf<T0, T1, T2>` to a `Tuple<T0, Nullable<T1>, T2>` so that any of the 3 types can be eventually deconstructed into a null value.

In other words: 
- When `OneOf<>`/`OneOfBase<>` is mapped into `Tuple<>` or `ValueTuple` any **non-nullable value-type `T` is converted into a nullable type `Nullable<T>`**
- This means that the standard tuple deconstructor will return a single non-null value, and all other values will be null
- As an example, `OneOf<SomeClass, SomeEnumType>` would be mapped into a `Tuple<SomeClass, Nullable<SomeEnumType>>`.  
  If this type is holding an instance of `SomeClass` then the deconstruction will return `null` for the second type instead of returning `default(SomeEnumType)` which would be the first enum value.

Our extension-methods can be applied both to `OneOf<>` and `OneOfBase<>`, and there is an extension for every possible combination of types (e.g. every combination of types from `T0..T1` up to `T0..T6`, where each one of those types may or may not be a non-nullable value type).  
All those combinations are created by a [CodegenCS](https://github.com/Drizin/CodegenCS) code generator [template](/src/CodeGenerator/GeneratorTemplate.cs).

## Subclassing alternative

If you are subclassing from `OneOfBase<>` (instead of using the standard `OneOf<>` structs) then instead of using our extension methods you can also create your own deconstructor.  
You can subclass with concrete types:
```cs
public class CreateUserResult : OneOfBase<User, CreateUserErrorEnum, List<ValidationError> {...}
```

...or you can subclass with generic types with explicit constraints
```cs
public class Result<TResult, TErrorEnum> : OneOfBase<TResult, TErrorEnum, List<ValidationError>>
    where TResult: class
    where TErrorEnum: struct
{...}
```

In both cases it's clear to the compiler what types are non-nullable value types and you can just handle that (and convert to nullable types) in your deconstructor (you don't need to use Tuples).

But why would you have that trouble (writing your own classes and destructors) if you can just rely in our extension-methods? :-) 



<hr>
<br/>
<br/>


# Motivation: using Discriminated Unions for the Result Pattern

The Result Pattern is a way of representing the outcome of an operation (whether it's successful or has encountered an error) in a more explicit and structured manner. It's an alternative to exception-based error handling. (Hold your horses - I'm not telling that you should never use exceptions - I'm just telling that there are some other design patterns that [might be used in conjunction](https://stackoverflow.com/a/46823898/3606250) to exceptions and in some cases might be better than throwing exceptions, especially if you're using [exceptions as flow control](https://www.youtube.com/watch?v=E3dU9Y1CsnI)). This pattern can be used by writing your own wrappers or by using some well-established libraries like [FluentResults](https://github.com/altmann/FluentResults), [error-or](https://github.com/amantinband/error-or), [ardalis Result](https://github.com/ardalis/Result), and [many others](https://github.com/youssefsell/Result.net). 

One downside of using a third-party library for Result pattern is that you will have limited degree of freedom for extensibility. As an example if you use [FluentResults](https://github.com/altmann/FluentResults) your methods will return a `Result` if they don't return any object in case of a success and will return `Result<T>` if they return type `T` in case of success - but in both types the errors are stored in a very generic `List<IError> Errors` which is very generic: it can both contain one or more errors, they can be of any type that implements `IError`, they can have different types inside it, etc. So basically the signature of a method `Result<SalesOrder>` doesn't give us any hint on what kind of errors we may get inside this result object.

By using **discriminated unions** and more specifically the [OneOf](https://github.com/mcintyre321/OneOf/) library we can solve this problem by making more explicit what are the possible errors that each method can return. As an example, consider the following signature:

```cs
public OneOf<Success<User>, Error<OutOfStockError>, Error<string>> CreateSalesOrder(SalesOrder order)
```

It's clear from the signature that the method will either return a `SalesOrder` (in case of success) or a `OutOfStockError` instance (which probably requires some special handling from the immediate-caller) or else some generic error represented by a single `string`, which probably should just be displayed to the user.

The `Success<T>` wrapper and `Error<T>` wrapper are just dummy wrappers that provide a clearer semantic on each type, but they are not required. You could for example have something like this:

```cs
public OneOf<SalesOrder, CreateSalesOrderErrorEnum, List<ValidationError>> CreateSalesOrder(SalesOrder order)
```

It's also clear from the signature that this method will either return a `SalesOrder` or a single error from a given enum type (which probably the immediate-caller should act upon) or a list of one-or-more validation errors that should probably just displayed in the UI.

To sum, discriminated unions provide a more idiomatic way of using the Result Pattern. Even when we don't want/need exhaustive type matching...


# Result-Pattern example (using OneOf and OneOf Tuple Deconstruction)

Let's say your service returns a discriminated-union like this:

```cs
/// <summary>
/// CreateUser returns ONLY one of these types (the others will be null): 
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
```

The standard way of handling this with OneOf would be doing a `Switch()` with a lambda for each type:

```cs
var oneOf = svc.CreateUser(createUserCommand);
oneOf.Switch(
    user => {
        // Successful return. Show created user or something like that
    },
    errorEnum => {
        // handle whatever error we got (instead of an enum we could also get individual types for each possible error)
    },
    validationErrors => {
        // Show the validation errors back to the UI
    });
```

But sometimes using switch and lambas can make our code complex and harder to maintain. Sometimes all we want is some early-returns.  
With ToTuple extensions and deconstruct operators we can use a concise golang-style syntax like this:


```cs
// ToValueTuple enables us to use deconstruction (which does not exist in OneOf library)
var (user, error, validationErrors) = service.CreateUser(createUserCommand).ToValueTuple();

if (validationErrors != null)
{
    // Show the validation errors back to the UI
    return;
}

// If it wasn't for the Nullable conversion then errorEnum
// would never possibly be null
if (errorEnum != null)
{
    // switch and handle
    return;
}

// else, success! (user!=null)
// Usually this is the larger code-block, 
// and that's why having early-returns for the other cases makes this code cleaner and easy to maintain!
// (no need to have a giant method with 3 different lambda-actions inside it)
```

<!--
The style above is based in golang syntax and guidelines:

- Regular expected error situations are handled with error results
- **fatal unexpected situations** are handled with **"panic"**  (pretty much like Exceptions in C#/Java)
- This encourages you to explicitly check for errors where they occur, as opposed to the paradigm that expects you to throw (and catch) exceptions even for expected errors.
- Since the language has this clear distinction between exceptions and return errors, it has some [conventions and constructs for error handling](https://blog.golang.org/error-handling-and-go) that allows developers to easily (and concisely) get and test errors.
- Basically, all functions where errors are expected to happen should always return an error object, and if the function is also expected to return some other object (in case of success) then it should use [**multiple return values**](https://gobyexample.com/multiple-return-values) so that it can simultaneously return both the expected result objects (at the first position) and then return the possible errors (at the last position)
- **Multiple return values** makes the code more concise. By receiving the error as a regular return value our error handling becomes **less verbose**, **more explicit**, and **easier to read** since it uses regular if/else statements.
- When returning multiple parameters **the return should always be ONE OR ANOTHER**, meaning that if there's an error you can expect that the other object is null, and vice-versa. This simple convention makes error handling much easier.

Last, another major benefit of explicitly returning error codes is that **exceptions can easily be ignored while it's much harder to ignore errors if your methods force you to receive the returned error**. Returning codes obviously don't allow us to bubble-up automatically (as exceptions do), but the idea is exactly that - you want to check (and act) on your errors right where they occur.
-->



## License
MIT License


