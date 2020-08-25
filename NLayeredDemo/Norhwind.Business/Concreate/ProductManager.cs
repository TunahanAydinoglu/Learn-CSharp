using Norhwind.Business.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concreate;
using Northwind.DataAccess.Concreate.EntityFramework;
using Northwind.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Norhwind.Business.Concreate
{
    public class ProductManager:IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //Business

            return _productDal.GetAll();
        }
    }
}
