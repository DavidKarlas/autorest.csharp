﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using AutoRest.CSharp.Common.Input;
using AutoRest.CSharp.Common.Output.Expressions.KnownValueExpressions.Base;
using AutoRest.CSharp.Common.Output.Expressions.ValueExpressions;
using AutoRest.CSharp.Common.Output.Models.Types;

namespace AutoRest.CSharp.Common.Output.Expressions.KnownValueExpressions
{
    internal sealed record SerializableObjectTypeExpression(SerializableObjectType ObjectType, ValueExpression Untyped) : TypedValueExpression(ObjectType.Type, Untyped)
    {
        public static MemberExpression FromResponseDelegate(SerializableObjectType serializableObjectType)
            => new(new TypeReference(serializableObjectType.Type), Configuration.ApiTypes.FromResponseName);

        public static MemberExpression DeserializeDelegate(SerializableObjectType serializableObjectType)
            => new(new TypeReference(serializableObjectType.Type), $"Deserialize{serializableObjectType.Declaration.Name}");

        public static SerializableObjectTypeExpression FromResponse(SerializableObjectType serializableObjectType, BaseResponseExpression response)
            => new(serializableObjectType, new InvokeStaticMethodExpression(serializableObjectType.Type, Configuration.ApiTypes.FromResponseName, new[] { response }));

        public static SerializableObjectTypeExpression Deserialize(SerializableObjectType serializableObjectType, ValueExpression element)
            => new(serializableObjectType, new InvokeStaticMethodExpression(serializableObjectType.Type, $"Deserialize{serializableObjectType.Declaration.Name}", new[] { element }));

        public RequestContentExpression ToRequestContent() => new(Untyped.Invoke(Configuration.ApiTypes.ToRequestContentName));

    }
}
