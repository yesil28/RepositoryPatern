using Repository_Patern.DataAccess.Abstract;
using Repository_Patern.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Patern.DataAccess.Concrete
{
    public class EfProductDal : IProductRepository
    {
        public void Creat(Product entity)
        {
            Console.WriteLine("EFProduct - create");
        }

     
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int dal)
        {
            throw new NotImplementedException();
        }

        public Product[] GetPopularProducts()
        {
            throw new NotImplementedException();
        }

        public Product[] GetProductsByCategory(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
