using mvcEX1.Models;
using mvcEX1.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcEX1.Controllers
{
    public class MoneyController : Controller
    {
        // GET: Money
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult ListMoney()
        {
            var db = new SkillTreeHomework();
            var accountBook = db.AccountBook;
            var moneys = new List<MoneyViewModel>();

            foreach (var item in accountBook)
            {
                moneys.Add(new MoneyViewModel(item.Id)
                {
                    MoneyType = (item.Categoryyy == 0 ? MoneyTypeEnum.Income : MoneyTypeEnum.Expend),
                    Amount = (decimal)item.Amounttt,
                    Date = item.Dateee,
                    Description = item.Remarkkk
                });
            }

            return View(moneys);
        }


    }
}