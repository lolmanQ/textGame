﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
	class Character
	{
		Register register = new Register();
		public static int health = 100;
		public static int attack = 0;
        public static int defence = 0;
		public static List<string> inventory = new List<string>();
        public static List<string> equiptItems = new List<string>();



		public void StatReset()
		{
			health = 100;
		}

		public void DisplayStats()
		{
			Console.WriteLine("Health: " + health);
			Console.WriteLine("atk: " + attack);
		}

		public void DisplayInventory()
		{
			string DisplayBufferInventory = "";
			foreach (string ItemId in inventory)
			{
				if (DisplayBufferInventory == "")
				{
					DisplayBufferInventory = register.GetName(ItemId);
				}
				else
				{
					DisplayBufferInventory += ", " + register.GetName(ItemId);
				}
			}
			Console.WriteLine("Your inventory contains: " + DisplayBufferInventory);
		}

		public void AddToInv(string item)
		{
			inventory.Add(item);
		}

		public List<string> GetInventory()
		{
			return inventory;
		}

		public void ChangeStats(string Stat, int Amount)
		{
			switch (Stat)
			{
				case "hp":
					health = health + Amount;
					break;
			}
		}

        public void CalculatePlayerStats()
        {

        }

        public void EquipItem()
        {
            string[] currentInventory = new string[] { };
            //Console.WriteLine("What item do you want to equip:");
            string itemToEquip = Console.ReadLine();
            itemToEquip = itemToEquip.ToLower();
            currentInventory = GetInventory().ToArray();
            for (int i = 0; i < currentInventory.Length; i++)
            {
                if (itemToEquip == currentInventory[i].ToLower())
                {
                    if (itemToEquip)
                }
            }
        }
    }
}
