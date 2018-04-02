using Microsoft.AspNetCore.Mvc;

namespace UrlsAndRoutes.Controllers
{
    public class LegacyController : Controller
    {
        public ViewResult GetLegacyUrl(string legacyUrl)
        {
            return View((object)legacyUrl);
        }
    }
}
