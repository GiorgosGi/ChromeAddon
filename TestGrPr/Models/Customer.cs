using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestGrPr.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FIrstName { get; set; }
        public string LastName { get; set; }
        public int Amka { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int AreaCode { get; set; }
        public HealthIssues HealthIssues { get; set; }
    }

    public enum HealthIssues
    {
        Yes, No, Unknown
    }
}