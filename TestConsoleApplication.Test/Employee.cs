//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestConsoleApplication.Test
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public Employee()
        {
            this.Orders = new HashSet<Order>();
        }
    
        public int Employee_ID { get; set; }
        public string Last_Name { get; set; }
        public string First_Name { get; set; }
        public string Title { get; set; }
        public Nullable<System.DateTime> Birth_Date { get; set; }
        public Nullable<System.DateTime> Hire_Date { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Postal_Code { get; set; }
        public string Country { get; set; }
        public string Home_Phone { get; set; }
        public string Extension { get; set; }
        public byte[] Photo { get; set; }
        public string Notes { get; set; }
        public Nullable<int> Reports_To { get; set; }
    
        public virtual ICollection<Order> Orders { get; set; }
    }
}
