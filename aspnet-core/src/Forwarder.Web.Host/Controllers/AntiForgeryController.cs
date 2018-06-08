using Microsoft.AspNetCore.Antiforgery;
using Forwarder.Controllers;

namespace Forwarder.Web.Host.Controllers
{
    public class AntiForgeryController : ForwarderControllerBase
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
