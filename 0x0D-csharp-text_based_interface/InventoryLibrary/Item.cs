using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
	public class Item : BaseClass
	{
		private string _name;

		public string name
		{
			get { return _name; }
			set
			{
				updatetime();
				_name = value;
			}
		}

		public string _descrption;

		public string descrption
		{
			get { return _descrption; }
			set
			{
				updatetime();
				_descrption = value;
			}
		}

		private float _price;

		public float price
		{
			get { return _price; }
			set
			{
				updatetime();
				_price = (float)Math.Round(value * 100) / 100f;
			}
		}

		public List<string> _tags;

		public List<string> tags
		{
			get { return _tags; }
			set
			{
				updatetime();
				_tags = value;
			}
		}

		public Item(string name)
		{
			this.name = name;
			tags = new List<string>();
		}
	}
}