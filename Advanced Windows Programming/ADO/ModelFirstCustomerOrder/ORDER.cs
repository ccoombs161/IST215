namespace ModelFirstCustomerOrder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ORDER")]
    public partial class ORDER
    {
        [Key]
        public int OrderNum { get; set; }

        [Required]
        [StringLength(35)]
        public string ProductNumber { get; set; }

        [Required]
        [StringLength(25)]
        public string ProductType { get; set; }

        [Required]
        [StringLength(75)]
        public string ProductName { get; set; }

        public int? CustomerID { get; set; }

        public virtual CUSTOMER CUSTOMER { get; set; }
    }
}
