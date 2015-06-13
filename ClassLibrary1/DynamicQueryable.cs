// Decompiled with JetBrains decompiler
// Type: System.Linq.Dynamic.DynamicQueryable
// Assembly: FlightBoard.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 00E69042-272F-4CC6-8791-14EADF11FA6E
// Assembly location: C:\Users\radhakrishnan\Desktop\Flight Board\FlightBoard.Core.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace System.Linq.Dynamic
{
    public static class DynamicQueryable
    {
        public static IQueryable<T> Where<T>(this IQueryable<T> source, string predicate, params object[] values)
        {
            return (IQueryable<T>)DynamicQueryable.Where((IQueryable)source, predicate, values);
        }

        public static IQueryable Where(this IQueryable source, string predicate, params object[] values)
        {
            if (source == null)
                throw new ArgumentNullException("source");
            if (predicate == null)
                throw new ArgumentNullException("predicate");
            LambdaExpression lambdaExpression = DynamicExpression.ParseLambda(source.ElementType, typeof(bool), predicate, values);
            return source.Provider.CreateQuery((Expression)Expression.Call(typeof(Queryable), "Where", new Type[1]
      {
        source.ElementType
      }, new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) lambdaExpression)
      }));
        }

        public static IQueryable Select(this IQueryable source, string selector, params object[] values)
        {
            if (source == null)
                throw new ArgumentNullException("source");
            if (selector == null)
                throw new ArgumentNullException("selector");
            LambdaExpression lambdaExpression = DynamicExpression.ParseLambda(source.ElementType, (Type)null, selector, values);
            return source.Provider.CreateQuery((Expression)Expression.Call(typeof(Queryable), "Select", new Type[2]
      {
        source.ElementType,
        lambdaExpression.Body.Type
      }, new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) lambdaExpression)
      }));
        }

        public static IQueryable<T> OrderBy<T>(this IQueryable<T> source, string ordering, params object[] values)
        {
            return (IQueryable<T>)DynamicQueryable.OrderBy((IQueryable)source, ordering, values);
        }

        public static IQueryable OrderBy(this IQueryable source, string ordering, params object[] values)
        {
            if (source == null)
                throw new ArgumentNullException("source");
            if (ordering == null)
                throw new ArgumentNullException("ordering");
            ParameterExpression[] parameters = new ParameterExpression[1]
      {
        Expression.Parameter(source.ElementType, "")
      };
            IEnumerable<DynamicOrdering> enumerable = new ExpressionParser(parameters, ordering, values).ParseOrdering();
            Expression expression = source.Expression;
            string str1 = "OrderBy";
            string str2 = "OrderByDescending";
            foreach (DynamicOrdering dynamicOrdering in enumerable)
            {
                expression = (Expression)Expression.Call(typeof(Queryable), dynamicOrdering.Ascending ? str1 : str2, new Type[2]
        {
          source.ElementType,
          dynamicOrdering.Selector.Type
        }, new Expression[2]
        {
          expression,
          (Expression) Expression.Quote((Expression) Expression.Lambda(dynamicOrdering.Selector, parameters))
        });
                str1 = "ThenBy";
                str2 = "ThenByDescending";
            }
            return source.Provider.CreateQuery(expression);
        }

        public static IQueryable Take(this IQueryable source, int count)
        {
            if (source == null)
                throw new ArgumentNullException("source");
            return source.Provider.CreateQuery((Expression)Expression.Call(typeof(Queryable), "Take", new Type[1]
      {
        source.ElementType
      }, new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Constant((object) count)
      }));
        }

        public static IQueryable Skip(this IQueryable source, int count)
        {
            if (source == null)
                throw new ArgumentNullException("source");
            return source.Provider.CreateQuery((Expression)Expression.Call(typeof(Queryable), "Skip", new Type[1]
      {
        source.ElementType
      }, new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Constant((object) count)
      }));
        }

        public static IQueryable GroupBy(this IQueryable source, string keySelector, string elementSelector, params object[] values)
        {
            if (source == null)
                throw new ArgumentNullException("source");
            if (keySelector == null)
                throw new ArgumentNullException("keySelector");
            if (elementSelector == null)
                throw new ArgumentNullException("elementSelector");
            LambdaExpression lambdaExpression1 = DynamicExpression.ParseLambda(source.ElementType, (Type)null, keySelector, values);
            LambdaExpression lambdaExpression2 = DynamicExpression.ParseLambda(source.ElementType, (Type)null, elementSelector, values);
            return source.Provider.CreateQuery((Expression)Expression.Call(typeof(Queryable), "GroupBy", new Type[3]
      {
        source.ElementType,
        lambdaExpression1.Body.Type,
        lambdaExpression2.Body.Type
      }, new Expression[3]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) lambdaExpression1),
        (Expression) Expression.Quote((Expression) lambdaExpression2)
      }));
        }

        public static bool Any(this IQueryable source)
        {
            if (source == null)
                throw new ArgumentNullException("source");
            return (bool)source.Provider.Execute((Expression)Expression.Call(typeof(Queryable), "Any", new Type[1]
      {
        source.ElementType
      }, new Expression[1]
      {
        source.Expression
      }));
        }

        public static int Count(this IQueryable source)
        {
            if (source == null)
                throw new ArgumentNullException("source");
            return (int)source.Provider.Execute((Expression)Expression.Call(typeof(Queryable), "Count", new Type[1]
      {
        source.ElementType
      }, new Expression[1]
      {
        source.Expression
      }));
        }
    }
}
