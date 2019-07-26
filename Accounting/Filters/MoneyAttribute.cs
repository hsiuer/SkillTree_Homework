using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Accounting.Filters
{
    public class MoneyAttribute : ValidationAttribute
    {
        /// <summary>
        /// 檢查是否為非零的正整數
        /// </summary>
        public override bool IsValid(object value)
        {

            if (value == null)
                return false;
            else if (!Regex.IsMatch(value.ToString(), "^[0-9]{1,11}$"))
                return false;
            else
                return true;
        }
    }
}