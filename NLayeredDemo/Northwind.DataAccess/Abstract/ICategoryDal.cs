using Northwind.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.DataAccess.Abstract
{
    public interface ICategoryDal:IEntityRepository<Category>
    {
    }
}
