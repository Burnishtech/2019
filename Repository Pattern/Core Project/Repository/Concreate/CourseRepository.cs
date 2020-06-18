using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlutoWeb.Core.Domain;
using PlutoWeb.Persistence;

namespace Core_Project.Repository.Concreate
{
   public class CourseRepository:Repository<Course>,ICourseRepository
    {
        public CourseRepository(PlutoContext context)
            : base(context)
        {
        }
        public IEnumerable<Course> GetTopSellingCourses(int count)
        {
            return PlutoContext.Courses.OrderByDescending(c => c.FullPrice).Take(count).ToList();
        }

        public IEnumerable<Course> GetCoursesWithAuthors(int pageIndex, int pageSize = 10)
        {
            return PlutoContext.Courses             
                .OrderBy(c => c.Name)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public PlutoContext PlutoContext
        {
            get { return context as PlutoContext; }
        }
    }
}
