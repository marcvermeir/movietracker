using System.Linq.Expressions;

namespace MT.Api.Data
{
    public class DataRequest<T> where T : class
    {
        public string? Query { get; set; }

        public Expression<Func<T, bool>>? Where { get; set; }
        public Expression<Func<T, object>>? OrderBy { get; set; }
        public Expression<Func<T, object>>? OrderByDesc { get; set; }
    }
}