using Knife.Server.Services.CategoryService;
using Knife.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Knife.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Category>>>> GetCategories()
        {
            var result = await _categoryService.GetCategoriesAsync();
            return Ok(result);
        }
        [HttpGet("{categoryId}")]
        public async Task<ActionResult<ServiceResponse<Category>>> GetCategory(int categoryId)
        {
            var result = await _categoryService.GetCategoryAsync(categoryId);
            return Ok(result);
        }
    }
}
