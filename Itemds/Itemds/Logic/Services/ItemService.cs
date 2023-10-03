using Itemds.Model;
using System.Data;
using System.Data.SqlClient;

namespace Itemds.Logic.Services
{
	public class ItemService
	{
		public static bool ItemSave(ItemModel model)
		{
			return DbHelper.ExecuteData("TB_Item_Save", () => ItemParameterSave(model, DbHelper.Command));

		}
		/*
		 @ItemGuid uniqueidentifier,
		   @ItemCode int,
		   @ItemName nvarchar(50),
		   @ParentGuid uniqueidentifier,
		   @itemPrice as decimal(10, 2),
		   @itemPriceSingle as decimal(10, 2),
		   @itemPriceMany as decimal(10, 2),
		   @IsGroup bit
		 */
		private static void ItemParameterSave(ItemModel model, SqlCommand command)
		{
			command.Parameters.Add("@ItemGuid", SqlDbType.UniqueIdentifier).Value
				= model.ItemGuid;
			command.Parameters.Add("@ItemCode", SqlDbType.Int).Value
				= model.ItemCode;
			command.Parameters.Add("@ItemName", SqlDbType.NVarChar).Value
				= model.ItemName;
			command.Parameters.Add("@ItemPrice", SqlDbType.Decimal).Value
				= model.ItemPrice;
			command.Parameters.Add("@ItemPriceSingle", SqlDbType.Decimal).Value
				= model.ItemPriceSingle;
			command.Parameters.Add("@itemPriceMany", SqlDbType.Decimal).Value
				= model.ItemPriceMany;
			command.Parameters.Add("@ParentGuid", SqlDbType.UniqueIdentifier).Value
				= model.ParentGuid;
			command.Parameters.Add("@IsGroup", SqlDbType.Bit).Value
				= model.IsGroup;
		}

	}
}