using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Taner.UI.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(Taner.Data.Db.Kullanici.List().ToDataSourceResult(request));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create([DataSourceRequest] DataSourceRequest request, Taner.Data.Entities.Kullanici kullanici)
        {
            if (kullanici != null && ModelState.IsValid)
            {
                Taner.Data.Db.Kullanici.Add(kullanici);
            }
            return Json(new[] { kullanici }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Update([DataSourceRequest] DataSourceRequest request, Taner.Data.Entities.Kullanici kullanici)
        {
            if (kullanici != null && ModelState.IsValid)
            {
                Taner.Data.Db.Kullanici.Update(kullanici);
            }
            return Json(new[] { kullanici }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Destroy([DataSourceRequest] DataSourceRequest request, Taner.Data.Entities.Kullanici kullanici)
        {
            if (kullanici != null)
            {
                Taner.Data.Db.Kullanici.Delete(kullanici.Id);
            }
            return Json(new[] { kullanici }.ToDataSourceResult(request, ModelState));
        }
    }
}