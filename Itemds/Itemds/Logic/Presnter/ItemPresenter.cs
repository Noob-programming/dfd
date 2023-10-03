using Itemds.Logic.Services;
using Itemds.Model;
using Itemds.View.Interfaces;

namespace Itemds.Logic.Presnter

{
	public class ItemPresenter
	{
		private IItems _items;
		ItemModel _model = new ItemModel();

		public ItemPresenter(IItems view)
		{
			_items = view;
		}

		void ConnectBetweenModelInterface()
		{
			_model.ItemGuid = _items.ItemGuid;
			_model.ItemCode = _items.ItemCode;
			_model.ItemName = _items.ItemName;
			_model.ItemPrice = _items.ItemPrice;
			_model.ItemPriceSingle = _items.ItemPriceSingle;
			_model.ItemPriceMany = _items.ItemPriceMany;
		}

		public bool Save()
		{
			ConnectBetweenModelInterface();
			return ItemService.ItemSave(_model);
		}

	}
}