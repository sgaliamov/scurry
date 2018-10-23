﻿using System.Linq;
using SCurry.Builders.Converters.Shared;
using SCurry.Builders.Models;
using SCurry.Builders.Shared;

namespace SCurry.Builders.Converters.Curry
{
    internal sealed class ArgumentsConverter : IConverter
    {
        private readonly TypeParametersConverter _typeParameters;

        public ArgumentsConverter(TypeParametersConverter typeParameters) => _typeParameters = typeParameters;

        public string Convert(MethodDefinition definition)
        {
            var types = _typeParameters.Convert(definition);

            var args = definition
                .Parameters
                .Where(x => x.IsArgument)
                .Select(x => $"{x.TypeName} {x.ArgumentName}")
                .Join(", ");

            if (!string.IsNullOrWhiteSpace(args))
            {
                args = ", " + args;
            }

            return $"this {definition.Delegate}{types} {definition.Target}{args}";
        }
    }
}
