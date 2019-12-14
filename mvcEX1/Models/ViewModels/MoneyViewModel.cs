using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcEX1.Models.ViewModels
{
    public class MoneyViewModel
    {
        private Guid id;
        public Guid ID { get { return this.id; } }
        public MoneyTypeEnum MoneyType { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public MoneyViewModel (Guid id)
        {
            this.id = id;
        }
    }
}