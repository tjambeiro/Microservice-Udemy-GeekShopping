using GeekShopping.Web.Models;
using GeekShopping.Web.Services.IServices;
using GeekShopping.Web.Utils;

namespace GeekShopping.Web.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _cliente;
        public const string BasePath = "api/v1/Product";

        public ProductService(HttpClient cliente)
        {
            _cliente = cliente ?? throw new ArgumentNullException(nameof(cliente));
        }

        public async Task<IEnumerable<ProductModel>> FindAllProducts()
        {
            var response = await _cliente.GetAsync(BasePath);
            return await response.ReadContentAs<List<ProductModel>>();
        }

        public async Task<ProductModel> FindById(long id)
        {
            var response = await _cliente.GetAsync($"{BasePath}/{id}");
            return await response.ReadContentAs<ProductModel>();
        }

        public async Task<ProductModel> CreateProduct(ProductModel model)
        {
            var response = await _cliente.PostAsJson(BasePath, model);
            return response.IsSuccessStatusCode ? await response.ReadContentAs<ProductModel>() 
                : throw new Exception("Something went wrong when calling API");
        }

        public async Task<ProductModel> UpdateProduct(ProductModel model)
        {
            var response = await _cliente.PutAsJson(BasePath, model);
            return response.IsSuccessStatusCode ? await response.ReadContentAs<ProductModel>() 
                : throw new Exception("Something went wrong when calling API");
        }

        public async Task<bool> DeleteProductById(long id)
        {
            var response = await _cliente.DeleteAsync($"{BasePath}/{id}");
            return response.IsSuccessStatusCode ? await response.ReadContentAs<bool>()
                : throw new Exception("Something went wrong when calling API");
        }
    }
}
