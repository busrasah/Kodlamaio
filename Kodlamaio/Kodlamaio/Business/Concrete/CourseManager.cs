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
    public class CourseManager : ICourseService
    {
        private readonly CourseDal _courseDal;
        public CourseManager(CourseDal courseDal)
        {
            _courseDal = courseDal;
        }
        public void Add(Course course)
        {
            _courseDal.Add(course);
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();

        }

        public void Remove(Course course)
        {
            _courseDal.Remove(course);
            
        }

        public void Update(Course course)
        {
            _courseDal.Update(course);
        }
    }
}
