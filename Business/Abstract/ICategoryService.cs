using Core.Utilities.Result.Base.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<Category> GetById(int categoryID);
        IDataResult<List<Category>> GetList();
        IResult Add(Category category);
        IResult Delete(Category category);
        IResult Update(Category category);
    }
}
