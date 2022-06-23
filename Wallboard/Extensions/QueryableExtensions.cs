using System.Linq.Expressions;
using Wallboard.Models;

namespace Wallboard.Extensions;

public static class QueryableExtensions
{
    public static IQueryable<T> CustomFilterCollection<T>(this IQueryable<T> posts, Expression<Func<T, bool>> predicate)
    {
        // use the predicate to filter the posts
        return posts;
    }
}