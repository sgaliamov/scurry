﻿using SCurry.Builders.Models;

namespace SCurry.Builders.Converters
{
    public sealed class MethodConverter : IConverter
    {
        private readonly IConverter _args;
        private readonly IConverter _body;
        private readonly IConverter _name;
        private readonly IConverter _result;

        public MethodConverter(IConverter result, IConverter name, IConverter args, IConverter body)
        {
            _args = args;
            _result = result;
            _body = body;
            _name = name;
        }

        public string Convert(MethodDefinition definition)
        {
            var result = _result.Convert(definition);
            var name = _name.Convert(definition);
            var args = _args.Convert(definition);
            var body = _body.Convert(definition);

            return $"public static {result} {name}({args}) => {body};";
        }
    }
}
