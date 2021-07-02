using AP.StarBug.Core.Repository.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AP.StarBug.UniTest.Repository
{
    public class ProductRepositoryTest
    {
        private readonly IProductRepository _repo;

        public ProductRepositoryTest()
        {
        }

        //[Fact]
        public void ProductGetAll()
        {
            // Act
            var products = _repo.GetAll();

            // Assert
        }
    }
}