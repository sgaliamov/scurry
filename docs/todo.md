# To do

- [x] GitHubFlow.
- [x] net standard 1.0.
- [x] Reorder arguments in builders.
- [x] ~~F~~ not possible.
- [x] ~~Light version. Simplify gaps for partial.~~ no reason to do.
- [x] ~~Builder:~~ separate project.

   ``` c#
   foo = a -> b -> c -> d -> e -> f -> g;
   g = foo.curry(a, _, c, _, _, f) --> foo.value(a).skip(1).value(b).skip(2).value(c).curry();
   g(b)(d)(e);

   g = foo.partial(a, _, c, _, _, f) --> foo.value(a).skip(1).value(b).skip(2).value(c).partial();
   g(b, d, e);
   ```

    `value` and `skip` functions return not `Func` but some object that works with function with less amount of arguments
