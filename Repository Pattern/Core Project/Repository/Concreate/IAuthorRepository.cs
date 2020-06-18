using PlutoWeb.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core_Project.Repository.Concreate
{
   public interface IAuthorRepository : IRepository<Author>
    {
        Author GetAuthorWithCourses(int id);
    }
}
