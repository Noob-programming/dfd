using System;

namespace Itemds.Model
{
    public class ItemModel
    {
        public Guid ItemGuid { get; set; }
        public int ItemCode { get; set; }
        public string ItemName { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal ItemPriceSingle { get; set; }
        public decimal ItemPriceMany { get; set; }
        public Guid ParentGuid { get; set; }
        public bool IsGroup { get; set; }

    }
}