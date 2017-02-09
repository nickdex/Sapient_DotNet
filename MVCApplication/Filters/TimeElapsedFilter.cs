using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApplication.Filters
{
    public class TimeElapsedFilter : FilterAttribute, IActionFilter
    {
        private Stopwatch watch;

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            watch = Stopwatch.StartNew();
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            watch.Stop();
            long millis = watch.ElapsedMilliseconds;
            filterContext.HttpContext.Response.Write("Time elapsed is: " + millis);
        }
    }
}