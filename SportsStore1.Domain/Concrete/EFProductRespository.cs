using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsStore1.Domain.Entities;
using SportsStore1.Domain.Abstract;

namespace SportsStore1.Domain.Concrete
{
    public class EFProductRespository : IProductRepository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }
    }
}
