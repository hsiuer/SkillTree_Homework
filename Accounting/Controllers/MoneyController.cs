using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Accounting.Models.Data;
using Accounting.Models.EntityFramework;
//using Accounting.Models.ViewModels;

namespace Accounting.Controllers
{
    public class MoneyController : Controller
    {
        DataAccess _dataAccess = new DataAccess();
        SkillTreeHomeworkEntities db = new SkillTreeHomeworkEntities();

        // GET: Money
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(AccountBook account)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    account.Id = Guid.NewGuid();
                    db.AccountBook.Add(account);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return View(account);
        }

        protected List<SelectListItem> GetTypes()
        {
            List<SelectListItem> ddlTypes = new List<SelectListItem>();
            ddlTypes.Add(new SelectListItem() { Text = "請選擇", Value = "", Selected = true });
            ddlTypes.Add(new SelectListItem() { Text = "支出", Value = "0", Selected = false });
            ddlTypes.Add(new SelectListItem() { Text = "收入", Value = "1", Selected = false });

            return ddlTypes;
        }

        [ChildActionOnly]
        public ActionResult ShowHistory()
        {
            //List<MoneyViewModel> history = new List<MoneyViewModel>();
            //string[] str = { "支出", "收入" };
            //DateTime start = new DateTime(2006, 1, 1);
            //int range = (DateTime.Today - start).Days;

            //var random = new Random();
            //for (int i = 0; i < 100; i++)
            //{
            //    var Category = str[random.Next(str.Length)];
            //    var Money = random.Next(100, 20000);
            //    var Day=start.AddDays(random.Next(range));

            //    history.Add(new MoneyViewModel(Category, Money, Day/*, string.Empty*/));
            //}
            //return View(history);
            var data = _dataAccess.GetList();
            return View(data);
        }

    }
}