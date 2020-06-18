using System;
using System.Collections.Generic;
using System.Text;
using PlutoWeb.Core.Domain;
namespace Core_Project.Repository.Concreate
{
    public interface ICourseRepository:IRepository<Course>
    {
        IEnumerable<Course> GetTopSellingCourses(int count);
        IEnumerable<Course> GetCoursesWithAuthors(int pageIndex, int pageSize);
    }
}
