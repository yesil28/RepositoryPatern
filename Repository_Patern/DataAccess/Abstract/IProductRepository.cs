using Repository_Patern.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Patern.DataAccess.Abstract
{
    interface IProductRepository:IRepository<Product>
    {
        Product[] GetProductsByCategory(int id);
        Product[] GetPopularProducts();
    }
}
