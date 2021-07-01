using AP.StarBug.Core.Entities;
using AP.StarBug.Core.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AP.StarBug.Core.Dao
{
    public class ProductService : IProductService
    {
        private readonly IDapperRepository _repository;

        public ProductService(IDapperRepository repository)
        {
            _repository = repository;
        }

        public List<Product> GetAll()
        {
            var result = _repository.GetAll<Product>($"Select * from [members]", null, commandType: CommandType.StoredProcedure);
            return result;
        }
    }
}
