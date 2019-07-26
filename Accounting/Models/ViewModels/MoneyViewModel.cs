using Accounting.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace Accounting.Models.ViewModels
{
    public class MoneyViewModel
    {
        [Required]
        [Display(Name = "類別")]
        public int SelectedTypes { get; set; }

        [Required]
        [Display(Name = "金額")]
        [Money(ErrorMessage = "金額需為正整數")]
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public int Money { get; set; }

        [Required]
        [Display(Name = "日期")]
        [DateEntered(ErrorMessage = "日期不得大於今天")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "備註")]
        [DataType(DataType.MultilineText)]
        [StringLength(100, ErrorMessage = "備註需在100字元以內")]
        public string Note { get; set; }

    }
}