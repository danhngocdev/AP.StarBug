using AP.StarBug.Core.Dao;
using AP.StarBug.Core.Dao.DTOS;
using AP.StarBug.Core.Entities;
using AP.StarBug.Core.Repository.Interface;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AP.StarBug.Core.Repository.Imp
{
    public class ProductRepository : IProductRepository
    {
        private readonly IMapper _mapper;
        private readonly IProductDao _productDao;

        public ProductRepository(IProductDao productDao, IMapper mapper)
        {
            _productDao = productDao;
            _mapper = mapper;
        }

        public List<Product> GetAll()
        {
            var result = _productDao.GetAll();
            var model = _mapper.Map<List<Product>>(result);
            return model;
        }
    }
}