using GeekShopping.Product.API.Data.ValueObjects;
using GeekShopping.Product.API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.ProductAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _repository.FindAll();
            return Ok(products);
        }

        [HttpGet("id")]
        public async Task<IActionResult> Get(long id)
        {
            var product = await _repository.FindById(id);
            if (product == null) return NotFound();

            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductVO vo)
        {
            if (vo == null) return BadRequest();
            var product = await _repository.Create(vo);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(ProductVO vo)
        {
            if (vo == null) return BadRequest();
            var product = await _repository.Update(vo);

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(long id)
        {
            var status = await _repository.DeleteById(id);
            if (!status) return BadRequest();
            return Ok();
        }
    }
}
