using Northwind.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Norhwind.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
    }
}
