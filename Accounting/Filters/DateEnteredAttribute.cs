using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Accounting.Filters
{
    public class DateEnteredAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateEntered = (DateTime)value;
            if (dateEntered <= DateTime.Today)
            {
                return true;
            }
            return false;
        }
    }
}