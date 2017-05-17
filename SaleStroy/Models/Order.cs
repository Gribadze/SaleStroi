using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SaleStroy.Models
{
    public class Order
    {
        [Key]
        [Display(Name = "Номер заказа")]
        public int Id { get; set; }
        [Display(Name = "Идентификатор товара")]
        public int IdTovar { get; set; }
        [Display(Name = "Количество")]
        public int Quantity { get; set; }
        [Display(Name = "Идентификатор пользователя")]
        public Guid IdUser { get; set; }
        [Display(Name = "Дата заказа")]
        public DateTime Date { get; set; }

    }
}