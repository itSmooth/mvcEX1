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

            var db = new SkillTreeHomework();
            var accountBook = db.AccountBook;
            var moneys = new List<MoneyViewmodel>();

            //var count = 300;
            //DateTime moneyDate = DateTime.Parse("2010-01-01");
            //var r = new Random();
            //for (int id = 0; id < count; id++)
            //{
            //    moneys.Add(new Money(id)
            //    {
            //        MoneyType = (r.Next(0, 2) == 0 ? MoneyTypeEnum.Income : MoneyTypeEnum.Expend),
            //        Amount = r.Next(1, 100000),
            //        Date = (moneyDate = moneyDate.AddDays(r.Next(1, 30))),
            //    });
            //}

            int id = 0;
            foreach(var item in accountBook)
            {
                // TODO ：當初訂 Viewmodel 裡的 ID 為 int，與實際資料庫內類型不同，加上 Viewodel現在不能改，暫時沒把 db 裡的 ID 放進來
                moneys.Add(new MoneyViewmodel(id)
                {
                    // TODO : 待確認： item.Categoryyy 0是收入??、 1是支出??
                    MoneyType = (item.Categoryyy == 0 ? MoneyTypeEnum.Income : MoneyTypeEnum.Expend),
                    Amount = (decimal)item.Amounttt,
                    Date = item.Dateee,
                    Description = item.Remarkkk
                });
                id++;
            }

            return View(moneys);
        }
    }
}