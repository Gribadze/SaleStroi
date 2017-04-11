using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IdentityMvc.Models
{
    public class Tovar
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Имя товара")]
        public string TovarName { get; set; }
        [Display(Name = "В наличии")]
        public int Quantity { get; set; }
        [Display(Name = "Цена")]
        public int Price { get; set; }
        [Display(Name = "Описание")]
        public string Def { get; set; }
    }
}