using InventoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InventoryManager
{
	internal class InventoryManager
	{
		public static JSONStorage storage = new JSONStorage();

		private static void Main(string[] args)
		{
			string help = String.Join(Environment.NewLine,
				 "Inventory Manager",
				 "------------------------",
				 "< ClassNames > show all ClassNames of objects",
				 "< All > show all objects",
				 "< All[ClassName] > show all objects of a ClassName",
				 "< Create[ClassName] > a new object",
				 "< Show[ClassName object_id] > an object",
				 "< Update[ClassName object_id] > an object",
				 "< Delete[ClassName object_id] > an object",
				 "<Exit>\n"
				);
			Console.WriteLine(help);
			storage.Load();

			while (true)
			{
				Console.WriteLine(">>");
				string commandLine = Console.ReadLine();
				Queue<string> arguments = new Queue<string>(commandLine.Split(" "));
				string command = arguments.Dequeue();
				switch (command)
				{
					case "Exit":
						Environment.Exit(0);
						break;

					case "ClassNames":
						Console.WriteLine($"{command} executed");
						break;

					case "Create":
						Create(arguments);
						break;

					case "All":
						All(arguments);
						break;

					case "Show":
						Show(arguments);
						break;

					case "Delete":
						Delete(arguments);
						break;

					case "Update":
						Update(arguments);
						break;

					default:
						Console.WriteLine($"no Command named {command} found");
						break;
				}
			}
		}

		public static void All(Queue<string> arguments)
		{
			if (arguments.Count > 0)
			{
				string className = arguments.Dequeue();
				foreach (var item in storage.objects.Where(
						item => item.Key.Split(".")[0] == className))
				{
					Console.WriteLine($"{item.Key}: {item.Value}");
				}
			}
			else
			{
				foreach (var item in storage.objects)
				{
					Console.WriteLine($"{item.Key}: {item.Value}");
				}
			}
		}

		public static void Create(Queue<string> arguments)
		{
			if (arguments.Count > 0)
			{
				string className = arguments.Dequeue();
				switch (className)
				{
					case "User":
						Console.Write("name: ");
						string name = Console.ReadLine();
						User user = new User(name);
						storage.New(user);
						storage.Save();
						Console.WriteLine("User Created");
						break;

					case "Item":
						Console.Write("name: ");
						string itemName = Console.ReadLine();
						Item newItem = new Item(itemName);
						storage.New(newItem);
						while (true)
						{
							Console.WriteLine("do you want to set more properties Y/N");
							string yes = Console.ReadLine();
							if (yes == "y")
							{
								Console.Write("description: ");
								string description = Console.ReadLine();
								float _price;
								while (true)
								{
									try
									{
										Console.Write("price : ");
										string price = Console.ReadLine();
										_price = float.Parse(price);
										break;
									}
									catch (Exception)
									{
										Console.WriteLine("pls select a float number");
									}
								}
								Console.WriteLine("create tags separated by one space ");
								string listoftags = Console.ReadLine();
								List<string> tags = new List<string>(listoftags.Split(" "));
								newItem.descrption = description;
								newItem.price = _price;
								newItem.tags = tags;
								break;
							}
							else if (yes == "n")
							{
								break;
							}
						}
						storage.Save();
						Console.WriteLine("Item Created");
						break;

					default:
						Console.WriteLine($"<{className}> is not a valid object type");
						break;
				}
			}
		}

		public static void Show(Queue<string> arguments)
		{
			if (arguments.Count > 0)
			{
				string className = arguments.Dequeue();
				if (className == "User" || className == "Item")
				{
					if (arguments.Count > 0)
					{
						string classId = arguments.Dequeue();
						while (true)
						{
							try
							{
								string res = storage.objects.Keys.First(item => item.Split(".")[1] == classId && className == item.Split(".")[0]);

								Console.WriteLine(storage.objects[res]);
								break;
							}
							catch (Exception)
							{
								Console.WriteLine($"Object <id> could not be found");
								Console.WriteLine("Repeat search Y/N");
								string yes = Console.ReadLine();
								if (yes == "n") break;
								else
								{
									Console.WriteLine($"pls select an <id> of <{className}> ");
									classId = Console.ReadLine();
								}
							}
						}
					}
					else
					{
						Console.WriteLine($"Object <id> could not be found");
					}
				}
				else
				{
					Console.WriteLine($"<{className}> is not a valid object type");
				}
			}
			else
			{
				Console.WriteLine($"<ClassName> is not a valid object type");
			}
		}

		public static void Delete(Queue<string> arguments)
		{
			if (arguments.Count > 0)
			{
				string className = arguments.Dequeue();
				if (className == "User" || className == "Item")
				{
					if (arguments.Count > 0)
					{
						string classId = arguments.Dequeue();
						while (true)
						{
							try
							{
								string res = storage.objects.Keys.First(item => item.Split(".")[1] == classId && className == item.Split(".")[0]);

								storage.objects.Remove(res);
								storage.Save();
								Console.WriteLine($"{classId} deleted successefully ");
								break;
							}
							catch (Exception)
							{
								Console.WriteLine($"Object <id> could not be found");
								Console.WriteLine("Repeat search Y/N");
								string yes = Console.ReadLine();
								if (yes == "n") break;
								else
								{
									Console.WriteLine($"Object <{classId}> could not be found");
									classId = Console.ReadLine();
								}
							}
						}
					}
					else
					{
						Console.WriteLine($"Object <id> could not be found");
					}
				}
				else
				{
					Console.WriteLine($"<{className}> is not a valid object type");
				}
			}
			else
			{
				Console.WriteLine($"<className> is not a valid object type");
			}
		}

		public static void Update(Queue<string> arguments)
		{
			if (arguments.Count > 0)
			{
				string className = arguments.Dequeue();
				if (className == "User" || className == "Item")
				{
					if (arguments.Count > 0)
					{
						string classId = arguments.Dequeue();
						while (true)
						{
							try
							{
								string key = storage.objects.Keys.First(item => item.Split(".")[1] == classId && className == item.Split(".")[0]);

								switch (className)
								{
									case "User":
										User user = storage.objects[key];
										Console.Write("update name : ");
										string name = Console.ReadLine();
										user.name = name;
										break;

									case "Item":
										Item item = storage.objects[key];
										Console.Write("update name : ");
										string itemName = Console.ReadLine();
										item.name = itemName;
										while (true)
										{
											Console.WriteLine("do you want to set more properties Y/N");
											string yes = Console.ReadLine();
											if (yes == "y")
											{
												Console.Write("description: ");
												string description = Console.ReadLine();
												float _price;
												while (true)
												{
													try
													{
														Console.Write("price : ");
														string price = Console.ReadLine();
														_price = float.Parse(price);
														break;
													}
													catch (Exception)
													{
														Console.WriteLine("pls select a float number");
													}
												}
												Console.WriteLine("replace old tags (separated by one space) ");
												string listoftags = Console.ReadLine();
												List<string> tags = new List<string>(listoftags.Split(" "));
												item.descrption = description;
												item.price = _price;
												item.tags = tags;
												break;
											}
											else if (yes == "n")
											{
												break;
											}
										}
										storage.Save();
										Console.WriteLine("Item updated");
										break;

									default:
										Console.WriteLine($"<{className}> is not a valid object type");
										break;
								}
								storage.Save();
								Console.WriteLine($"{classId} updated successefully ");
								break;
							}
							catch (Exception)
							{
								Console.WriteLine($"Object <{classId}> could not be found");
								Console.WriteLine("Repeat search Y/N");
								string yes = Console.ReadLine();
								if (yes == "n") break;
								else
								{
									Console.WriteLine($"enter new {className} <id>");
									classId = Console.ReadLine();
								}
							}
						}
					}
					else
					{
						Console.WriteLine($"Object <id> could not be found");
					}
				}
				else
				{
					Console.WriteLine($"<{className}> is not a valid object type");
				}
			}
			else
			{
				Console.WriteLine($"<className> is not a valid object type");
			}
		}
	}
}
