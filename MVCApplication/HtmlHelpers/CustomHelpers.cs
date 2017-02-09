using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApplication.HtmlHelpers
{
    public static class CustomHelpers<T>
    {
        public static MvcHtmlString CreateGrid<T>(this HtmlHelper helper, IEnumerable<T> source)
        {
            String outString = "<table class='table'>";
            var properties = source[0].GetProperties().ToList();

            foreach (var item in source)
	            {
		            outString += "<tr>";
                    Type model = item.GetType();

                    object instance = Activator.CreateInstance(model);

                    foreach (var propertyInfo in model.GetProperties())
                    {
                        outString += "<td>";
                        var value = propertyInfo.GetValue(instance);
                        outString += "</td>";
                        
                    }
                    
                    //properties.ForEach(p => outString += string.Format("<th>{0}</th>", Convert.ChangeType(p.GetValue(), p.GetType())));
            
                    outString += "</tr>";

	            }
            

            outString += "</table>";
        }
    }
}