using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Accounting.Models.ViewModels
{
    public class MoneyViewModel
    {
        public MoneyViewModel()
        {
            //建構子
        }

        public MoneyViewModel(string types, int money, DateTime date/*, string note*/)
        {
            this.SelectedTypes = types;
            this.Money = money;
            this.Date = date;
            //this.Note = note;
        }

        public string SelectedTypes { get; set; }

        [Required]
        [Display(Name = "類別")]
        public IEnumerable<SelectListItem> Types { get; set; }

        [Required]
        [Display(Name = "金額")]
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public int Money { get; set; }

        [Required]
        [Display(Name = "日期")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Date { get; set; }

        [Display(Name = "備註")]
        public string Note { get; set; }
    }
}