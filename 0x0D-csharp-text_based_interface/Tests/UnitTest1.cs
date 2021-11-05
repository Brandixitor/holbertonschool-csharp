using InventoryLibrary;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Tests
{
	public class Tests
	{
		public static int id;
		public List<string> ListUsers = new List<string>() { "salah", "wael", "ahmed", "Amine", "salah", "mostafa", "kamel" };
		public List<string> ListItems = new List<string>() { "shoes", "boat", "pool", "table", "chair", "sofa", "spoon" };
		public string randomName { get { return getRandomName(); } set { } }
		public string randomItem { get { return getRandomItem(); } set { } }

		public string getRandomName()
		{
			int index = new Random().Next(0, ListUsers.Count);
			string randomName = ListUsers[index];

			ListUsers.Remove(randomName);
			return randomName;
		}

		public string getRandomItem()
		{
			int index = new Random().Next(0, ListItems.Count);
			string randomItem = ListItems[index];

			ListItems.Remove(randomItem);
			return randomItem;
		}

		public string test_id(BaseClass instance)
		{
			id++;
			return $"{instance.GetType().Name}_" + id;
		}

		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void All_Class_instance_BaseClass()
		{
			User user = new User(randomName);
			user.id = test_id(user);
			user.date_created = new DateTime();
			user.date_updated = new DateTime();
			Assert.IsInstanceOf<BaseClass>(user);
			Item item = new Item(randomItem);
			Assert.IsInstanceOf<BaseClass>(item);
			Inventory inv = new Inventory(user, item, 5);
			Assert.IsInstanceOf<BaseClass>(user);
		}

		[Test]
		public void test_quantity()
		{
			User user = new User(randomName);
			Item item = new Item(randomItem);
			Inventory inv = new Inventory(user, item, 5);
			Assert.AreEqual(5, inv.quantity);

			Inventory inv1 = new Inventory(user, item);
			Assert.AreEqual(1, inv1.quantity);

			Inventory inv2 = new Inventory(user, item, -6);
			Assert.AreEqual(0, inv2.quantity);
		}

		[Test]
		public void test_price()
		{
			Item item = new Item(randomItem);
			item.price = 5.15424f;
			Assert.AreEqual(5.15f, item.price);
			Item item1 = new Item(randomItem);
			item1.price = 0;
			Assert.AreEqual(0.00, item1.price);
			Item item2 = new Item(randomItem);
			item2.price = 5.1f;
			Assert.AreEqual(5.10f, item2.price);
		}
	}
}