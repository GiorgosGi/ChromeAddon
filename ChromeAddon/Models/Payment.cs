using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestGrPr.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int PaymentMethod { get; set; }
        public int OrderId { get; set; }
    }
}