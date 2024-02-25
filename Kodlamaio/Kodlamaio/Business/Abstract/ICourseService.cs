using Kodlamaio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.Business.Abstract
{
    public interface ICourseService
    {
        List<Course>GetAll();
        void Add(Course course);
        void Remove(Course course);
        void Update (Course course);


    }
}
