using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestGrPr.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public DateTime OrderDate { get; set; }
        public bool OrderStatus { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}