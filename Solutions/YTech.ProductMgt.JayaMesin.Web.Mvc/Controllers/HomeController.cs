using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Web.Mvc;
//using YTech.ProductMgt.JayaMesin.Domain.Contracts.Tasks;
//using YTech.Inventory.JayaMesin.Web.Mvc.Controllers.ViewModels;
using System.Linq;
using YTech.ProductMgt.JayaMesin.Domain;
using System;

namespace YTech.ProductMgt.JayaMesin.Web.Mvc.Controllers
{
    [HandleError]
    public partial class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
