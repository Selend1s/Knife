using Knife.Shared;
using System.Net.Http.Json;

namespace Knife.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _http;

        public List<Category> Categories { get; set; } = new List<Category>();
        public CategoryService(HttpClient http)
        {
            _http = http;
        }

        public async Task GetCategories()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/Categories");
            if (result != null)
                Categories = result.Data;
        }

        public async Task<ServiceResponse<Category>> GetCategory(int categoryId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<Category>>($"api/Categories/{categoryId}");
            return result;
        }
    }
}
