using System.Web.Mvc;

namespace BloodManagmentSystem.ViewModels
{
    public class EmailFormModel
    {
        public string To { get; set; }
        public string Subject { get; set; }

        [AllowHtml]
        public string Message { get; set; }
    }
}