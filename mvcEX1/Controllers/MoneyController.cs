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

        [HttpPost]
        public ActionResult Index(MoneyViewModel money)
        {
            if (ModelState.IsValid)
            {
                var db = new SkillTreeHomework();
                var accountBook = new AccountBook();
                accountBook.Id = Guid.NewGuid();
                accountBook.Amounttt =(int) money.Amount;
                accountBook.Categoryyy =(int) money.MoneyType;
                accountBook.Dateee = money.Date;

                // TODO : Remarkkk沒填資料會出現 錯誤，資料是 空字串、空白符號，也不行，暫時填上 ?
                accountBook.Remarkkk = money.Description != null ? money.Description : "?";
                db.AccountBook.Add(accountBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
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
                moneys.Add(new MoneyViewModel()
                {
                    ID = item.Id,
                    MoneyType = (item.Categoryyy == 0 ? MoneyTypeEnum.Income : MoneyTypeEnum.Expend),
                    Amount = (decimal)item.Amounttt,
                    Date = item.Dateee,
                    Description = item.Remarkkk
                }) ;
            }

            return View(moneys);
        }


    }
}