using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestGrPr.Models
{
    public class MedicalCenter
    {
        public int Id { get; set; }
        public string MedicalCenterName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int AreaCode { get; set; }
    }
}