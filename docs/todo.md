# To do

- [x] GitHubFlow
- [x] netstandard1.0
- [x] Reorder arguments in builders.
- [ ] Simplify gaps for partial.
- [ ] F
- [ ] Light version
- [ ] Builder:

   ``` c#
   foo = a -> b -> c -> d -> e -> f -> g;
   g = foo.curry(a, _, c, _, _, f) --> foo.value(a).skip(1).value(b).skip(2).value(c).curry();
   g(b)(d)(e);

   g = foo.partial(a, _, c, _, _, f) --> foo.value(a).skip(1).value(b).skip(2).value(c).partial();
   g(b, d, e);
   ```

- [ ] Builder based on expression tree.
