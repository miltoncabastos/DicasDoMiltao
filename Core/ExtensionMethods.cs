using System;
using System.Linq;
using System.Linq.Expressions;

namespace Core
{
    public static class ExtensionMethods
    {
        public static IQueryable<TSource> WhereIf<TSource>(this IQueryable<TSource> source, bool condition, Expression<Func<TSource, bool>> predicate)
        {
            return condition ? source.Where(predicate) : source;
        }
    }
}
