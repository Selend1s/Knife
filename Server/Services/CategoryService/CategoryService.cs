using Knife.Shared;

namespace Knife.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _context;

        public CategoryService(DataContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponse<List<Category>>> GetCategoriesAsync()
        {
            var result = new ServiceResponse<List<Category>>
            {
                Data = await _context.Categories.ToListAsync(),
            };
            return result;
        }

        public async Task<ServiceResponse<Category>> GetCategoryAsync(int categoryId)
        {
            var response = new ServiceResponse<Category>();
            var category = await _context.Categories.FindAsync(categoryId);
            if (category == null)
            {
                response.Success = false;
                response.Message = $"Sorry, we have not find the category by your category Id.";
            }
            else
            {
                response.Data = category;
                response.Message = $"We have find the {category.Name} category";
            }
            return response;
        }
    }
}
