using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace InventoryLibrary
{
	public class JSONStorage

	{
		public Dictionary<string, dynamic> objects = new Dictionary<string, dynamic>();

		public void New(dynamic obj)
		{
			try
			{
				objects.Add($"{obj.GetType().Name}.{obj.id}", obj);
			}
			catch (Exception)
			{
				Console.WriteLine("please provide Class Instance That Inhirit from BaseClass");
			}
		}

		public Dictionary<string, dynamic> All()
		{
			return objects;
		}

		public void Save()
		{
			var options = new JsonSerializerOptions { WriteIndented = true };
			string fileName = "../../../../storage/inventory_manager.json";
			string jsonString = JsonSerializer.Serialize(objects, options);
			File.WriteAllText(fileName, jsonString);

		}

		public void Load()
		{
			string fileName = "../../../../storage/inventory_manager.json";
			string jsonString = File.ReadAllText(fileName);
			objects = JsonSerializer.Deserialize<Dictionary<string, dynamic>>(jsonString);
		}
	}
}