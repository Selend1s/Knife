using Knife.Shared;

namespace Knife.Client.Services.ProductServices
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        //Product product { get; set; }
        Task GetProducts();
        Task<ServiceResponse<Product>> GetProduct(int productId);
    }
}
