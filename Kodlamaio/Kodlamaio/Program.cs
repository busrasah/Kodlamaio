using Kodlamaio.Business.Abstract;
using Kodlamaio.Business.Concrete;
using Kodlamaio.DataAccess.Abstract;
using Kodlamaio.DataAccess.Concrete;
using Kodlamaio.Entities;



CategoryManager categoryManager = new CategoryManager(new CategoryDal());
List<Category> categories = categoryManager.GetAll();

CourseManager courseManager = new CourseManager(new CourseDal());
List<Course> courses = courseManager.GetAll();

InstructorManager instructorManager = new InstructorManager(new InstructorDal());
List<Instructor> instructors = instructorManager.GetAll();

Category category = new Category() { Id = categoryManager.GetAll().Count() + 1, CategoryName = "C++" };
