using NewspaaperCoreGrapgQL.Entities.Models;
using System.Collections.Generic;

namespace NewspaaperCoreGrapgQL.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();

        Category GetById(int id);

        Category Add(Category category);

        Category Update(Category category);

        void Delete(Category category);
    }
}
