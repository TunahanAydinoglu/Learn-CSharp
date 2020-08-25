using Northwind.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();
        Product Get(int id);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
