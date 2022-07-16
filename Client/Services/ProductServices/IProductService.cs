using Knife.Shared;

namespace Knife.Client.Services.ProductServices
{
    public interface IProductService
    {
        event Action CategoryChange;
        List<Product> Products { get; set; }
        //Product product { get; set; }
        Task GetProducts(string? categoryUrl=null);
        Task<ServiceResponse<Product>> GetProduct(int productId);
    }
}
