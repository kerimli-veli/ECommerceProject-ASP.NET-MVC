using ECommerce.WebUI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace ECommerce.WebUI.ViewComponents;

//[ViewComponent(Name = "CartSummary")]
public class CartSummaryViewComponent(ICatSessionService sessionService) : ViewComponent
{
    private readonly ICatSessionService _sessionService = sessionService;

    public ViewViewComponentResult Invoke()
    {
        var model = new CartSummaryViewModel()
        {
            Cart = _sessionService.GetCart()
        };
        return View(model);
    }
}
