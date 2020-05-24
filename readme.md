# Currying C# functions and actions

If you are here, you probably know what [Curry](https://en.wikipedia.org/wiki/Currying) and [Partial Application](https://en.wikipedia.org/wiki/Partial_application) are. This library contains extensions for all standard *Func<>* and *Action<>* delegates.

[![Build status](https://ci.appveyor.com/api/projects/status/u0yhhrc3p11eqyt5/branch/master?svg=true)](https://ci.appveyor.com/project/sgaliamov/scurry/branch/master)
[![codecov](https://codecov.io/gh/sgaliamov/scurry/branch/master/graph/badge.svg)](https://codecov.io/gh/sgaliamov/scurry)
[![NuGet Badge](https://buildstats.info/nuget/scurry)](https://www.nuget.org/packages/scurry/)

## Features

1. Supports all standard `Func<>` and `Action<>` delegates.
1. Currying and uncurrying.
1. Partial Application with special spacer.
1. *Pipe* and *Compose* helper functions.
1. All code is auto generated and covered by unit tests.
1. .NET Standard 1.0+
1. No external dependencies.

## Examples

Lets say you have the next function:

``` c#
Func<int, int, int, int> Multiply = (a, b, c) => a * b * c;
```

### Partial Application

The library contains [Partial Application](https://en.wikipedia.org/wiki/Partial_application) extensions for all standard delegates:

``` c#
Func<int, int, int> multiply2Partial = Multiply.Partial(2, 3);
int result = multiply2Partial(4); // 24
```

In case if you know the values for some arguments in advance you can use the spacer:

``` c#
using static SCurry.Spacer;
...
Func<int, int, int> multiply2Partial = Multiply.Partial(_, _, 2); // or Multiply.Partial(1, _, 2) or Multiply.Partial(_, 2)
int result = multiply2Partial(3, 4); // 24
```

At the moment you can use the spacer for delegates with up to 7 parameters. Making it more makes the library ridiculous big.

### Curry

To curry use *Curry* extension:

``` c#
Func<int, Func<int, Func<int, int>>> multiplyCurried = Multiply.Curry();
int result = multiplyCurried(2)(3)(4); // 24
```

You can combine it with gapped version of *Partial* extension to get more flexibility:

``` c#
using static SCurry.Spacer;
...
Func<int, int> multiply2 = Multiply.Partial(_, _, 2).Curry();
int result = multiply6(5)(6); // 30
```

### Uncurry

After curry you may want to get normal function back:

``` c#
Func<int, int> multiply2curryed = Multiply.Partial(_, _, 2).Curry();
Func<int, int, int> multiply2 = multiply2curryed.Uncurry();
int result = multiply2(3, 4); // 24
```

### Pipe and Compose

You can chain functions with *Pipe* helper:

``` c#
using static SCurry.Piper;
...
Func<int, int, int, int> Multiply = (a, b, c) => a * b * c;
Func<int, int> CurryedAdd2WithGap = TestFunctions.Add2.Partial(_, 2).Curry();
Func<int, Func<int, int>> CurryedPartialMultiplyBy3 = Multiply.Partial(_, _, 3).Curry();
Func<int, Func<int, Func<int, int>>> CurryedAdd3 = TestFunctions.Add3.Curry();

var piped = Pipe(
    CurryedAdd2WithGap,
    CurryedPartialMultiplyBy3(1),
    CurryedAdd3(3)(1)
);

var result = piped(0); // 10
```

Or [Compose](https://en.wikipedia.org/wiki/Function_composition) them to evaluate functions in reverse order:

``` c#
using static SCurry.Composer;
...
var piped = Compose(
    CurryedAdd2WithGap,
    CurryedPartialMultiplyBy3(1),
    CurryedAdd3(3)(1)
);

var result = piped(0); // 14
```

## Installation

``` ps
PM> Install-Package SCurry
```

``` cmd
dotnet add package SCurry
```
