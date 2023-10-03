using System;

namespace Itemds.View.Interfaces
{
    public interface IItems
    {
        Guid ItemGuid { get; set; }
        int ItemCode { get; set; }
        string ItemName { get; set; }
        decimal ItemPrice { get; set; }
        decimal ItemPriceSingle { get; set; }
        decimal ItemPriceMany { get; set; }
        Guid ParentGuid { get; set; }
        bool IsGroup { get; set; }

    }
}
