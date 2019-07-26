using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Accounting.Helpers
{
    public static class CategoryHelper
    {
        public static HtmlString DisplayCategoryColor(this HtmlHelper htmlHelper ,int types)
        {
            var className = "";
            var CategoryName = "";

            if (types==0)
            {
                className = "primary";
                CategoryName = "收入";

            }
            else
            {
                className = "danger";
                CategoryName = "支出";
            }
            return new MvcHtmlString($"<span class='text-{className}'>{CategoryName}</span>");
        }
    }
}
