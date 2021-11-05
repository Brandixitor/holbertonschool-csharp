namespace InventoryLibrary
{
	public class User : BaseClass

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

		public User(string name) : base()
		{
			this.name = name;
		}


	}
}