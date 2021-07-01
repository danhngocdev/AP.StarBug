using AP.StarBug.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AP.StarBug.Core.Dao
{
   public  interface IProductService
    {
        List<Product> GetAll();
    }
}
