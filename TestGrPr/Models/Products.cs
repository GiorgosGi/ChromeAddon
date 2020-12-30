using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestGrPr.Models
{
    public class Products
    {
        public int Id { get; set; }
        public int MedicalCenterId { get; set; }
        public string ProductName { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public double Price { get; set; }
        public int InitialQuantity { get; set; }
        public int StockQuantity { get; set; }

    }

    public enum ProductCategory
    {
        TestCovid, VaccineCovid
    }
}