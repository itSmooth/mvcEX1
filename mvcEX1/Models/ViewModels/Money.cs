using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcEX1.Models.ViewModels
{
    public class Money
    {
        private int id;
        public int ID { get { return this.id; } }
        public MoneyTypeEnum MoneyType { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public Money (int id)
        {
            this.id = id;
        }
    }

    public enum MoneyTypeEnum
    {
        Income = 0,
        Expend = 1
    }
}