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
            var moneys = new List<Money>();
            var count = 300;
            DateTime moneyDate = DateTime.Parse("2010-01-01");
            var r = new Random();

            for (int id = 0; id < count; id++)
            {
                moneys.Add(new Money(id)
                {
                    MoneyType = (r.Next(0, 2) == 0 ? MoneyTypeEnum.Income : MoneyTypeEnum.Expend),
                    Amount = r.Next(1, 100000),
                    Date = (moneyDate = moneyDate.AddDays(r.Next(1, 30))),
                });
            }
            return View(moneys);
        }
    }
}