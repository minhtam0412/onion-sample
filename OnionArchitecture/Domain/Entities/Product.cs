using System;
using System.ComponentModel;
using Domain.Common;

namespace Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Barcode { get; set; }
        public decimal? Rate { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; } = null;

        public int CreatedBy { get; set; }
    }
}