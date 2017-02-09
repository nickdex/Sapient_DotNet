using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApplication.HtmlHelpers
{
    public static class CustomHelpers
    {
        public static MvcHtmlString CreateGrid<T>(this HtmlHelper helper, IEnumerable<T> source)
        {
            String outString = "<table class='table'>";
            
            Type type = typeof(T);

            var properties = type.GetProperties().ToList();

            outString += "<tr>";

            

            foreach(var property in properties) 
            {
                outString += "<th>";
                outString += property.Name;
                outString += "</th>";
            }
            outString += "</tr>";

            foreach (var item in source)
	        {
		            outString += "<tr>";
                    
                    foreach (var propertyInfo in type.GetProperties())
                    {
                        outString += "<td>";
                        outString += propertyInfo.GetValue(item);

                        outString += "</td>";
                        
                    }
                               
                    outString += "</tr>";
            }
            
            outString += "</table>";
            return MvcHtmlString.Create(outString);
        }
    }
}