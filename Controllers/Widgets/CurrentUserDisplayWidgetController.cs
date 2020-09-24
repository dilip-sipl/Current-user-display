using CurrentUserDisplayWidget.Controllers.Widgets;
using CurrentUserDisplayWidget.Models.Widgets;
using Kentico.PageBuilder.Web.Mvc;
using System.Web.Mvc;
using CMS.Membership;

[assembly: RegisterWidget("SIPL.CurrentUserDisplay", typeof(CurrentUserDisplayWidgetController), "Current user display", Description = "Displays the information of the currently logged in user", IconClass = "icon-square")]
namespace CurrentUserDisplayWidget.Controllers.Widgets
{
    public class CurrentUserDisplayWidgetController : WidgetController<CurrentUserDisplayWidgetProperties>
    {
        // GET: CurrentUserDisplay
        public ActionResult Index()
        {
            var properties = GetProperties();

            string value = "";
            var isUserAuthenticated = AuthenticationHelper.IsAuthenticated();
            if (isUserAuthenticated)
            {
                value = properties.ContentBefore;

                if (!string.IsNullOrEmpty(properties.UserField))
                    value += MembershipContext.AuthenticatedUser.GetStringValue(properties.UserField, "");

                value += properties.ContentAfter;
            }

            ViewBag.DisplaySelectedPropertyValue = value;

            return PartialView("Widgets/_CurrentUserDisplay");
        }
    }
}
