using System.Web.Mvc;

namespace BloodManagmentSystem.ViewModel
{
    public class EmailFormModel
    {
        public string To { get; set; }
        public string Subject { get; set; }

        [AllowHtml]
        public string Message { get; set; }
    }
}