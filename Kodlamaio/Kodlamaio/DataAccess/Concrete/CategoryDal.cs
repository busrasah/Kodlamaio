using Kodlamaio.DataAccess.Abstract;
using Kodlamaio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal
    {

        List<Category> _categories;
        public CategoryDal()
        {
            Category category1= new Category();
            category1.Id = 1;
            category1.Name = "C#";

            Category category2= new Category();
            category2.Id = 2;
            category2.Name = "Python";

            Category category3= new Category();
            category3.Id = 3;
            category3.Name = "Angular";


            _categories = new List<Category> { category1, category2, category3 };

        }
        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public void Remove(Category category)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Category entity)
        {
            var data = _categories.FirstOrDefault(x => x.Id == entity.Id);
            if (data != null) data = entity;

        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
