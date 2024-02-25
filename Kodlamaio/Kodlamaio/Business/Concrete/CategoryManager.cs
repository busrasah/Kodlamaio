using Kodlamaio.Business.Abstract;
using Kodlamaio.DataAccess.Concrete;
using Kodlamaio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly CategoryDal _categoryDal;
        public CategoryManager(CategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public void Remove(Category category)
        {
            _categoryDal.Remove(category);
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
