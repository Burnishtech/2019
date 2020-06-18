using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Concrete
{
   public class EFProductRepository : IProductRepository
    {
        private EFDbcontext Context = new EFDbcontext();
        public IEnumerable<Product> Products {
            get { return Context.Products; } }

      //  IEnumerable<Entities.Product> IProductRepository.Products => throw new NotImplementedException();
    }
}

