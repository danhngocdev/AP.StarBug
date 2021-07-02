using AP.StarBug.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AP.StarBug.Core.Repository.Interface
{
    public interface IProductRepository
    {
        List<Product> GetAll();
    }
}