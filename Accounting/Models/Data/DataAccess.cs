using Accounting.Models.EntityFramework;
using Accounting.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Accounting.Models.Data
{
    public class DataAccess : IDataAccess
    {

        public IEnumerable<MoneyViewModel> GetList()
        {
            using (var _accountData = new SkillTreeHomeworkEntities())
            {
                return (from c in _accountData.AccountBook
                        select new MoneyViewModel
                        {
                            SelectedTypes = c.Categoryyy.ToString(),
                            Date = c.Dateee,
                            Money = c.Amounttt,
                            Note = c.Remarkkk
                        }).ToList();
            }
        }
    }
}