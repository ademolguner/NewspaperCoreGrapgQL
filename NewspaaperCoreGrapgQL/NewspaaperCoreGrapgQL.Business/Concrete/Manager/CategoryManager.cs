using NewspaaperCoreGrapgQL.Business.Abstract;
using NewspaaperCoreGrapgQL.DataAccess.Abstract;
using NewspaaperCoreGrapgQL.Entities.Models;
using System.Collections.Generic;

namespace NewspaaperCoreGrapgQL.Business.Concrete.Manager
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public Category Add(Category category)
        {
            _categoryDal.Add(category);
            return category;
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }

        public Category GetById(int id)
        {
            return _categoryDal.Get(c => c.CategoryId == id);
        }

        public Category Update(Category category)
        {
            _categoryDal.Update(category);
            return GetById(category.CategoryId);
        }
    }
}
