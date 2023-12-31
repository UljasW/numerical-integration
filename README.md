# README: Integration Service

## Overview

The `IntegrationService` class provides a method to numerically integrate a given function using parabolic approximation. This method divides the interval of integration into smaller subintervals and approximates the function with a parabola on each subinterval. The integral is then computed by summing up the areas under these parabolas.

## Namespace

```csharp
namespace integration.service;
```

## Public Methods

### `IntegrateBetween(decimal accuracy, decimal a, decimal b, Func<decimal, decimal> f)`

- **Parameters**:
  - `accuracy`: The width of each subinterval.
  - `a`: The start of the interval of integration.
  - `b`: The end of the interval of integration.
  - `f`: The function to be integrated.
- **Returns**: The approximate value of the integral of `f` over the interval `[a, b]`.
- **Description**: This method divides the interval `[a, b]` into subintervals of width `accuracy` and computes the integral by summing up the areas under parabolic approximations on each subinterval.

## Private Methods

### `findG(decimal i, decimal accuracy, Func<decimal, decimal> f, decimal prevG)`

- **Description**: Computes the area under the parabolic approximation on a given subinterval.
- **Note**: If the function value is undefined, it returns the previous value.

### `FindB(decimal x1, decimal y1, decimal y2, decimal x3, decimal y3, decimal x2)`

- **Description**: Calculates the coefficient `b` for the parabolic approximation using the substitution method.

## Example Usage

```csharp
using System.Runtime.CompilerServices;
using integration.service;

var interator = new IntegrationService();
decimal result = interator.IntegrateBetween((decimal)0.01,-2,2,f);
Console.WriteLine($"Approximate integral: {result}");

decimal f(decimal x){
    decimal y = 5*x*(decimal)Math.Sin((double)x);
    return y;
}
```

In the example above, the function `f` is integrated over the interval `[-2, 2]` with an accuracy of `0.01`. The result is then printed to the console.

## Additional Notes

- Ensure that the function `f` is well-defined over the interval of integration.
- The accuracy parameter determines the precision of the approximation. Smaller values of `accuracy` will result in a more accurate approximation but may increase computation time.
