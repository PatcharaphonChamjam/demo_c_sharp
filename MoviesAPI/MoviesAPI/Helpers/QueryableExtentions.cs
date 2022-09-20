using MoviesAPI.DTOs;
using System.Linq;

namespace MoviesAPI.Helpers
{
    public static class QueryableExtentions
    {
        public static IQueryable<T> Pagination<T>(this IQueryable<T> queryable, PaginationDTO pagination)
        {
            return queryable
                .Skip((pagination.Page - 1) * pagination.RecordPerPage)
                .Take(pagination.RecordPerPage);
        }
    }
}