using ECommerce.Application.Abstract;
using ECommerce.Application.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace ECommerce.WebUI.ViewComponents
{
    public class CategoryListViewComponent(ICategoryService categoryService ) : ViewComponent
    {
        private readonly ICategoryService _categoryService = categoryService;

        public ViewViewComponentResult Invoke()
        {
            var model = new CategoryListViewModel
            {
                Categories = _categoryService.GetAll()
            };
            return View( model );
        }

    }
}
