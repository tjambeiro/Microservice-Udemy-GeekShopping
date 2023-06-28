﻿using GeekShopping.Product.API.Data.ValueObjects;

namespace GeekShopping.Product.API.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductVO>> FindAll();
        Task<ProductVO> FindById(long id);
        Task<ProductVO> Create(ProductVO vo);
        Task<ProductVO> Update(ProductVO vo);
        Task<bool> DeleteById(long id);
    }
}
