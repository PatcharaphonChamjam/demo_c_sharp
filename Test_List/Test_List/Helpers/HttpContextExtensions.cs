using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Threading.Tasks;
using System;
using Microsoft.EntityFrameworkCore;

namespace Test_List.Helpers
{
    public static class HttpContextExtensions
    {
        public static async Task InsertPaginationParametersInResponse<T>(this HttpContext httpContext,
            IQueryable<T> queryable, int recordsPerPage)
        {
            if (httpContext == null) { throw new ArgumentNullException(nameof(httpContext)); }

            double count = await queryable.CountAsync();
            double totalAmountPages = Math.Ceiling(count / recordsPerPage);
            httpContext.Response.Headers.Add("totalAmountPages", totalAmountPages.ToString());
        }
    }
}