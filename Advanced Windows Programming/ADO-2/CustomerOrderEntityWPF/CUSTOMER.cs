//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CustomerOrderEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class CUSTOMER
    {
        public CUSTOMER()
        {
            this.ORDERs = new HashSet<ORDER>();
        }
    
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string EmailDomain { get; set; }
        public string PhoneAreaCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZIP { get; set; }
    
        public virtual ICollection<ORDER> ORDERs { get; set; }
    }
}