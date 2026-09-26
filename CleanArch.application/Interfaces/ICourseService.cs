using CleanArch.application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.application.Interfaces
{
    public interface ICourseService
    {

        IEnumerable<CourseViewModel> GetCourses();

    }
}
