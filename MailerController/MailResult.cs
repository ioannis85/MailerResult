using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MailerController
{
   public class MailResult:ActionResult
    {
       private readonly dynamic _model;
       private readonly string _viewName;
       public MailResult(dynamic model, string viewName) : base()
       {
           this._model = model;
           this._viewName = viewName;
       }

       public override void ExecuteResult(ControllerContext context)
       {
           
       }

    }
}
