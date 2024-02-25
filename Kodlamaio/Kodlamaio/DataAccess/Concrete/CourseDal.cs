using Kodlamaio.DataAccess.Abstract;
using Kodlamaio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.DataAccess.Concrete
{ 
    public class CourseDal : ICourseDal
    {
        List<Course> _courses;
        public CourseDal()
        {
            Course course1 = new Course();
            course1.Id = 1;
            course1.CategoryId = 1;
            course1.CourseName = "C#";
            course1.Description = "...";
            course1.Price = 750;

            Course course2 = new Course();
            course2.Id = 2;
            course2.CategoryId = 2;
            course2.CourseName = "Python";
            course2.Description = "...";
            course2.Price = 900;

            Course course3 = new Course();
            course3.Id = 3;
            course3.CategoryId = 3;
            course3.CourseName = "Angular";
            course3.Description = "...";
            course3.Price = 1000;

            _courses = new List<Course> { course1 , course2, course3};  
        }
        public void Add(Course course)
        {
            _courses.Add(course);
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public void Remove(Course course)
        {
            Course courseToDelete =  _courses.SingleOrDefault(c => c.Id == course.Id);
            if (course != null)
            {
                _courses.Remove(courseToDelete);
            }
        }

        public void Update(Course course)
        {
            Course courseToUpdate = _courses.SingleOrDefault(c => c.Id == course.Id);
            if (courseToUpdate != null)
            {
                courseToUpdate.CourseName = course.CourseName;
            }
        }
    }
}
