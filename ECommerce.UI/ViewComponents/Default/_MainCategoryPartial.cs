using ECommerce.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.UI.ViewComponents.Default
{
    public class _MainCategoryPartial : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public _MainCategoryPartial(ICategoryService categoryService)
        {
            _categoryService = categoryService;

        }

        public IViewComponentResult Invoke()
        {
            var values = _categoryService.TGetList();
            return View(values);
        }
    }
}
