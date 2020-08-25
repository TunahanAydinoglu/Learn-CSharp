using Northwind.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.DataAccess.Concreate.EntityFramework
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category,NorthwindContext>
    {
    }
}
