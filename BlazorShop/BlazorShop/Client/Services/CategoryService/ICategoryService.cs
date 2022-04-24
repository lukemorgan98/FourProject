using BlazorShop.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorShop.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        List<Category> Categories { get; set; }

        Task LoadCategories();
    }
}
