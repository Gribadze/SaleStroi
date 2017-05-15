using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaleStroy.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int IdTovar { get; set; }
        public int Quantity { get; set; }
        public Guid IdUser { get; set; }
        public DateTime Date { get; set; }
    }
}