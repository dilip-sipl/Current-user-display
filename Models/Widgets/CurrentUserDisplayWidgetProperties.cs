using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;

namespace CurrentUserDisplayWidget.Models.Widgets
{
    public class CurrentUserDisplayWidgetProperties : IWidgetProperties
    {
        [EditingComponent(DropDownComponent.IDENTIFIER, Label = "User field", Order = 0)]
        [EditingComponentProperty(nameof(DropDownProperties.DataSource), "FirstName;First name\r\nFullName;Full name\r\nEmail;Email\r\nUserName;Username")]
        public string UserField { get; set; }

        [EditingComponent(TextAreaComponent.IDENTIFIER, Label = "Content before", Order = 1)]
        public string ContentBefore { get; set; }

        [EditingComponent(TextAreaComponent.IDENTIFIER, Label = "Content after", Order = 2)]
        public string ContentAfter { get; set; }
    }
}
