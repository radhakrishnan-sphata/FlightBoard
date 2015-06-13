// Decompiled with JetBrains decompiler
// Type: System.Linq.Dynamic.DynamicExpression
// Assembly: FlightBoard.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 00E69042-272F-4CC6-8791-14EADF11FA6E
// Assembly location: C:\Users\radhakrishnan\Desktop\Flight Board\FlightBoard.Core.dll

using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace System.Linq.Dynamic
{
    public static class DynamicExpression
    {
        public static Expression Parse(Type resultType, string expression, params object[] values)
        {
            return new ExpressionParser((ParameterExpression[])null, expression, values).Parse(resultType);
        }

        public static LambdaExpression ParseLambda(Type itType, Type resultType, string expression, params object[] values)
        {
            return DynamicExpression.ParseLambda(new ParameterExpression[1]
      {
        Expression.Parameter(itType, "")
      }, resultType, expression, values);
        }

        public static LambdaExpression ParseLambda(ParameterExpression[] parameters, Type resultType, string expression, params object[] values)
        {
            return Expression.Lambda(new ExpressionParser(parameters, expression, values).Parse(resultType), parameters);
        }

        public static Expression<Func<T, S>> ParseLambda<T, S>(string expression, params object[] values)
        {
            return (Expression<Func<T, S>>)DynamicExpression.ParseLambda(typeof(T), typeof(S), expression, values);
        }

        public static Type CreateClass(params DynamicProperty[] properties)
        {
            return ClassFactory.Instance.GetDynamicClass((IEnumerable<DynamicProperty>)properties);
        }

        public static Type CreateClass(IEnumerable<DynamicProperty> properties)
        {
            return ClassFactory.Instance.GetDynamicClass(properties);
        }
    }
}
