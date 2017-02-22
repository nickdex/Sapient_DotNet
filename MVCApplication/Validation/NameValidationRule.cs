using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApplication.Validation
{
    public class NameValidationRule : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return false;
            }

            if ((value as string).Length < 6)
            {
                return false;
            }

            return true;
        }
    }
}