using System.Threading;
using System.Web;
using System.Web.Mvc;
using MVCAjaxFormUpload.Models;

namespace MVCAjaxFormUpload.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Product product)
        {
            var isAjax = this.Request.IsAjaxRequest();

            //todo: save the product
            //todo: return the id of the saved product, for instance 12:
            return Json(new { result = "ok", Id = 12 }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult UploadFiles(HttpPostedFileBase image1, int id)
        {
            var isAjax = this.Request.IsAjaxRequest();
            Thread.Sleep(3000); // simulating a long running process

            //todo: save the file
            //todo: find the product based on the received `id` and then update its name, etc.

            return Json(new { FileName = "/Uploads/filename.ext" }, "text/html", JsonRequestBehavior.AllowGet);
        }
    }
}