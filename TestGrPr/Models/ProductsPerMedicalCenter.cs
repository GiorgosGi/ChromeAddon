using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestGrPr.Models
{
    public class ProductsPerMedicalCenter
    {
        public int ProductId { get; set; }
        public int MedicalCenterId { get; set; }
        public int InitialQuantity { get; set; }
    }
}