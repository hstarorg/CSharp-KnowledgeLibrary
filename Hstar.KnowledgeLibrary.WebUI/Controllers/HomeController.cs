using System.Web.Mvc;
using Hstar.KnowledgeLibrary.Business;

namespace Hstar.KnowledgeLibrary.WebUI.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IHomeBusiness homeBusiness;

        public HomeController()
        {
            homeBusiness = new HomeBusiness();
        }
        [HttpGet]
        public ActionResult Index()
        {

            var model=homeBusiness.GetKnowledgeList(1,"");
            return View();
        }
    }
}