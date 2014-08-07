using System.Web.Mvc;

namespace Hstar.KnowledgeLibrary.WebUI.Controllers
{
    /// <summary>
    /// 控制器基类
    /// </summary>
    public class BaseController : Controller
    {
        public string UserId
        {
            get
            {
                //Windows认证下的用户名称（当前电脑名/域账户）
                var userInfo = HttpContext.User.Identity.Name.Split('\\');
                if (userInfo.Length == 2)
                {
                    return userInfo[1];
                }
                return string.Empty;
            }
        }
        protected override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (string.IsNullOrEmpty(this.UserId))
            {
                filterContext.Result=new HttpUnauthorizedResult("未授权！");
            }
            base.OnAuthorization(filterContext);
        }
    }
}
