using Core.Entities;

namespace Core.Specification
{
    public class MovieByDirectorSpecification : BaseSpecifcation<Movie>
    {
        public MovieByDirectorSpecification()
        {
            AddOrderByDescending(x => x.Director);
        }
    }
}