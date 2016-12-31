using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace biewj.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : biewjControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}