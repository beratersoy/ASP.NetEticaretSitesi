using stajrapor.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace stajrapor.Models
{
    public class UserOrder
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public double Total { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderState OrderState { get; set; }
    }
}