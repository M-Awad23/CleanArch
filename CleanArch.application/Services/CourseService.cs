using CleanArch.application.Interfaces;
using CleanArch.application.ViewModels;
using CleanArchDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.application.Services
{
    public class CourseService : ICourseService
    {
        private ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public IEnumerable<CourseViewModel> GetCourses()
        {
            throw new NotImplementedException();
        }
    }
}
