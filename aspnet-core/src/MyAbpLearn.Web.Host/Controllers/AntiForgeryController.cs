using Microsoft.AspNetCore.Antiforgery;
using MyAbpLearn.Controllers;

namespace MyAbpLearn.Web.Host.Controllers
{
    public class AntiForgeryController : MyAbpLearnControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
