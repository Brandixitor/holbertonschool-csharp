using System;

namespace InventoryLibrary
{
	public class BaseClass
	{
		private static int idCounter = 0;
		public string id;
		public DateTime date_created;
		public DateTime date_updated;

		public BaseClass()
		{
			id = GenerateId();
			date_created = new DateTime();
			date_updated = new DateTime();
		}

		public virtual string GenerateId()
		{
			Guid uuid = Guid.NewGuid();

			return uuid.ToString();
		}

		public virtual void updatetime()
		{
			date_updated = new DateTime();
		}

		public string GetAllClassAttributes()
		{
			string res = "{";
			string sep = "";
			foreach (var prop in GetType().GetProperties())
			{
				if (prop.GetValue(this, null)?.GetType() == typeof(String[]))
				{
				}
				res += String.Join("", $"{sep}{prop.Name}: {prop.GetValue(this, null)}");
				sep = ", ";
			}
			res += "}";
			return res;
		}

		public override string ToString()
		{
			return $"{{{id}: {GetAllClassAttributes()} }}";
		}
	}
}