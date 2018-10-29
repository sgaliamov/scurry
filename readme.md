# Currying C# functions and actions

## About

If you are here, you probably know what [Curry](https://en.wikipedia.org/wiki/Currying) and [Partial application](https://en.wikipedia.org/wiki/Partial_application) are. This library contains extensions for all standard *Func<>* and *Action<>* delegates.

[![Build status](https://ci.appveyor.com/api/projects/status/2ppb58d9a8gmvdfw/branch/master?svg=true)](https://ci.appveyor.com/project/sgaliamov/scurry/branch/master) [![codecov](https://codecov.io/gh/sgaliamov/scurry/branch/master/graph/badge.svg)](https://codecov.io/gh/sgaliamov/scurry)

## Features

1. Supports all standard Func<> and Action<> delegates.
1. Curry and Partial application with special spacer.
1. Uncurrying.
1. *Pipe* and *Compose* helper functions.
1. All code is auto generated and covered by unit tests.
1. Based on .NET Standard 2.0
1. No external dependencies.

## Examples

Lets say you have the next function:

``` c#
Func<int, int, int, int> Multiply = (a, b, c) => a * b * c;
```

### Curry

In simple case you can do this:

``` c#
Func<int, Func<int, Func<int, int>>> multiplyCurried = Multiply.Curry();
int multiplyCurried = multiply(2)(3)(4); // 24
```

In case if you know the values for some arguments in advance you can use the spacer:

``` c#
using static SCurry.Spacer;
...
Func<int, int> multiply6 = Multiply.Curry(3, _, 2); // or Multiply.Curry(_, _, 6) or or Multiply.Curry(_, 6)
int result = multiply(5); // 30
```

At the moment you can use the spacer for delegates with up to 6 parameters.

Also, as crazy as it sounds, the library supports "partial application" for curry. You can define first arguments for delegates with up to 8 parameters:

``` c#
Func<int, int, int, int, int, int, int, int, int> Multiply8 = (a, b, c, d, e, f, g, h) => a * b * c * d * e * f * g * h;
...
Func<int, int> curried = Multiply8.Curry(1, 2, 3, 4, 5, 6, 7);
int result = curried(8); // 40320
```

### Uncurry

After curry you may want get normal function back:

``` c#
Func<int, Func<int, int>> multiply2curryed = Multiply.Curry(_, 2);
Func<int, int, int> multiply2curryed = multiply2.Uncurry();
int result = multiply2(3, 4); // 24
```

### Partial Application

The library has Partial Application extensions for all delegates:

``` c#
Func<int, int, int> multiply2Partial = Multiply.Partial(2);
int result = multiply2Partial(3, 4); // 24
```

Also at the moment you can use the spacer for delegates with up to 6 parameters:

``` c#
Func<int, int, int> multiply2Partial = Multiply.Partial(_, _, 2);
int result = multiply2Partial(3, 4); // 24
```

### Pipe

``` c#
using static SCurry.Piper;
...

```

### Compose

``` c#
using static SCurry.Composer;
...
```

## Installation

``` ps
PM> Install-Package SCurry
```

``` cmd
dotnet add package SCurry
```

## Links

* [Development process](./process.md).
