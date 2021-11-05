namespace InventoryLibrary
{
	public class Inventory : BaseClass
	{
		private string _user_id;

		public string user_id
		{
			get { return _user_id; }
			set
			{
				updatetime();
				_user_id = value;
			}
		}

		private string _item_id;

		public string item_id
		{
			get { return _item_id; }
			set
			{
				updatetime();
				_item_id = value;
			}
		}

		private int _quantity;

		public int quantity
		{
			get { return _quantity; }
			set
			{
				updatetime();
				if (value < 0) value = 0;
				_quantity = value;
			}
		}

		public Inventory(User user, Item item, int quantity = 1)
		{
			user_id = user.id;
			item_id = item.id;
			this.quantity = quantity;
		}
	}
}