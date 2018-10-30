# To do

1. Reorder arguments in builders.
1. Simplify gaps for partial.
1. Builder:

   ``` c#
   foo = a -> b -> c -> d -> e -> f -> g;
   g = foo.curry(a, _, c, _, _, f) --> foo.value(a).skip(1).value(b).skip(2).value(c).curry();
   g(b)(d)(e);

   g = foo.partial(a, _, c, _, _, f) --> foo.value(a).skip(1).value(b).skip(2).value(c).partial();
   g(b, d, e);
   ```

1. Builder based on expression tree.
