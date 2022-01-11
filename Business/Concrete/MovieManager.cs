using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Contants;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Core.Utilities.Result.Base.Abstract;
using Core.Utilities.Result.Success;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    [LogAspect(typeof(DatabaseLogger))]
    [LogAspect(typeof(FileLogger))]
    public class MovieManager : IMovieService
    {
        private IMovieDal _movieDal;

        public MovieManager(IMovieDal movieDal)
        {
            _movieDal = movieDal;
        }
        [SecuredOperation("Admin,SubAdmin")]
        [CacheRemoveAspect("IMovieService.Get")]
        public IResult Add(Movie movie)
        {
            _movieDal.Add(movie);
            return new SuccessResult(Messages.MovieAdded);
        }
        [SecuredOperation("Admin,SubAdmin")]
        [CacheRemoveAspect("IMovieService.Get")]
        public IResult Update(Movie movie)
        {
            _movieDal.Update(movie);
            return new SuccessResult(Messages.MovieUpdated);
        }
      
        [SecuredOperation("Admin,SubAdmin")]
        [CacheRemoveAspect("IMovieService.Get")]
        public IResult Delete(Movie movie)
        {
            _movieDal.Delete(movie);
            return new SuccessResult(Messages.MovieDeleted);
        }

        public IDataResult<Movie> GetById(int movieID)
        {            
            return new SuccessDataResult<Movie>(
                _movieDal.Get(p => p.Id == movieID)
            );
        }
   
        [CacheAspect(duration: 10)]
        public IDataResult<List<Movie>> GetList()
        {
            return new SuccessDataResult<List<Movie>>(_movieDal.GetList().ToList()); 
        }
    }
}