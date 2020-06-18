using Core_Project.Repository.Concreate;
using System;
using System.Collections.Generic;
using System.Text;
using PlutoWeb.Core.Domain;
namespace Core_Project
{
    public interface IUnitOfWork : IDisposable
    {
        ICourseRepository Courses { get; }
        IAuthorRepository Authors { get; }
        int Complete();
    }
}
