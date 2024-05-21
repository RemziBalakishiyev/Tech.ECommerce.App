using Microsoft.AspNetCore.Mvc;

namespace Tech.ECommerce.UI.TViewCompoenents
{
    public class HeaderViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
