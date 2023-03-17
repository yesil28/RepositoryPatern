using Repository_Patern.DataAccess.Abstract;
using Repository_Patern.DataAccess.Concrete;
using Repository_Patern.Entity;
using System;

namespace Repository_Patern
{
    class ProductManager : IProductRepository
    {
        IProductRepository _repository;


        public ProductManager(IProductRepository repository)
        {
            _repository = repository;
        }


        public void Creat(Product entity)
        {
            _repository.Creat(entity);
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


    class Program
    {
        static void Main(string[] args)
        {
            //var productDal = new EfProductDal();
            //var productDal = new MySQLProductDal();

            //productDal.Creat(new Product());

            var productDal = new ProductManager(new EfProductDal());

            productDal.Creat(new Product());

            Console.ReadKey();
        }
    }
}
