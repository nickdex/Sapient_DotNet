using MVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApplication.ModelBinder
{
    public class PersonBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            Person person = new Person();
            var collection = controllerContext.HttpContext.Request.Form;
            person.Name = collection["txtName"];
            person.Age = Convert.ToInt16(collection["Age"]);
            person.Salary = Convert.ToSingle(collection["Salary"]);
            person.DOB = Convert.ToDateTime(collection["DOB"]);
            return person;
        }
    }
}