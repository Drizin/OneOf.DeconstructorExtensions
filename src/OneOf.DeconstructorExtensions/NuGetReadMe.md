# OneOf.DeconstructorExtensions

**This library extends `OneOf<>` and `OneOfBase<>` with deconstructors methods to deconstruct into the underlying types.

The major problem solved by this library is that **deconstruction is not trivial because of non-nullable value types**, so all non-nullable value types are automatically converted into nullable types, so the underlying Tuple values will always have a single non-null value (all other values will be null).
