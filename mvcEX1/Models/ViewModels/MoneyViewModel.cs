using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcEX1.Models.ViewModels
{
    public class MoneyViewModel
    {
        private Guid id;
        
        [Display(Name ="編號")]
        public Guid ID { get { return this.id; } }

        [Display(Name ="類別")]
        public MoneyTypeEnum MoneyType { get; set; }

        [Display(Name="金額")]
        [Required(ErrorMessage = "金額為必填項目")]
        public decimal Amount { get; set; }

        [Display(Name ="日期")]
        [Required(ErrorMessage = "日期為必填項目")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        
        [Display(Name ="備註")]
        [MaxLength(100,ErrorMessage ="最多輸入100字")]
        public string Description { get; set; }

        public MoneyViewModel (Guid id)
        {
            this.id = id;
        }
    }
}