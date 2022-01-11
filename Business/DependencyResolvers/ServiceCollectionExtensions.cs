using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Security.Jwt.Trans;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;

namespace Business.DependencyResolvers
{
    /// <summary>
    ///  Start up dostasına eklenecek
    ///  AddScoped kısmı
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        public static void AddApplicationBusinessDependencies(this IServiceCollection services)
        {
            services.AddSingleton<ICategoryService, CategoryManager>();
            services.AddSingleton<ICategoryDal, EfCategoryDal>();

            services.AddSingleton<IMovieService, MovieManager>();
            services.AddSingleton<IMovieDal, EfMovieDal>();

            services.AddSingleton<IUserService, UserManager>();
            services.AddSingleton<IUserDal, EfUserDal>();

            services.AddSingleton<IAuthService, AuthManager>();
            services.AddSingleton<ITokenHelper, JwtHelper>();
        }
    }
}
