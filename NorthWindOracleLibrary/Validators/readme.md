This folder has validators for the defined models. They are not all complete so that the reader can work through for missing rules such as each `Product` must have a `SupplierId`.

**Example**

```csharp
RuleFor(product => product.SupplierId)
    .GreaterThan(0)
    .NotNull();
```