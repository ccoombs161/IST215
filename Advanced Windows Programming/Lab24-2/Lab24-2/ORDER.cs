//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab24_2
{
    using System;
    using System.Collections.Generic;
    
    public partial class ORDER
    {
        public int OrderNum { get; set; }
        public string ProductNumber { get; set; }
        public string ProductType { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> CustomerID { get; set; }
    
        public virtual CUSTOMER CUSTOMER { get; set; }
    }
}
