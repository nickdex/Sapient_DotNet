using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApplication.Filters
{
    public class NotImplExceptionFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            //filterContext.HttpContext.Response.Redirect(errorUrl, true);
            string errorUrl = "~/Errors/GenericError.html";
            filterContext.ExceptionHandled = true;

            filterContext.Result = new ViewResult()
            {
                ViewName = errorUrl
            };
            
        }
    }
}