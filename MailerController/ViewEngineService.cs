using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
namespace MailerController
{
    class ViewEngineService
    {
        protected string GetCompiledView(ControllerContext controllerContext, dynamic model, string viewName)
        {
            var viewData = controllerContext.Controller.ViewData;
            var tempData = controllerContext.Controller.TempData;
           viewData.Model = model;
            using (var sw = new StringWriter())
            {
                var viewResult = ViewEngines.Engines.FindPartialView(controllerContext,
                                                                         viewName);
                var viewContext = new ViewContext(controllerContext, viewResult.View,
                                             viewData, tempData, sw);
                viewResult.View.Render(viewContext, sw);
                viewResult.ViewEngine.ReleaseView(controllerContext, viewResult.View);
                return sw.GetStringBuilder().ToString();
            }


        }


    }
}
