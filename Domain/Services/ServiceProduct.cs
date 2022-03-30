using Domain.Interfaces.InterfaceProduct;
using Domain.Interfaces.InterfaceSevices;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ServiceProduct : IServiceProduct
    {
        private readonly IProduct _IProduct;

        public ServiceProduct(IProduct IProduct)
        {
            _IProduct = IProduct;
        }

        public Task AddProduct(Product product)
        {
            var validateName = product.ValidatePropertyString(product.Nome, "nome")
        }

        public Task UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
