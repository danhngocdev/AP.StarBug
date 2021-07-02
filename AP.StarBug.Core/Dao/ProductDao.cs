using AP.StarBug.Core.Dao.DTOS;
using AP.StarBug.Core.Entities;
using AP.StarBug.Core.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AP.StarBug.Core.Dao
{
    public class ProductDao : IProductDao
    {
        private readonly IDapperRepository _repository;

        public ProductDao(IDapperRepository repository)
        {
            _repository = repository;
        }

        public List<ProductDto> GetAll()
        {
            var result = _repository.GetAll<ProductDto>("stpGetAllProduct", null, commandType: CommandType.StoredProcedure);
            return result;
        }
    }
}