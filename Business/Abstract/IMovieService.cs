using Core.Utilities.Result.Base.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IMovieService
    {
        IDataResult<Movie> GetById(int movieID);
        IDataResult<List<Movie>> GetList();
        IResult Add(Movie movie);
        IResult Delete(Movie movie);
        IResult Update(Movie movie);
    }
}
