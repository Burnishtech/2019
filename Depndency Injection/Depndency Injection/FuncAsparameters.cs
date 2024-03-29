﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        class Item
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        static void Main(string[] args)
        {
            List<Item> items = new List<Item>
            {
                new Item(){ Id = 1, Name = "Adam" },
                new Item(){ Id = 2, Name = "Billy" },
                new Item(){ Id = 3, Name = "Cecil" }
            };

            Console.WriteLine("Length == 5");
            PrintItems(items, x => x.Name.Length == 5);

            Console.WriteLine("Id is odd number");
            PrintItems(items, r => r.Id % 2 == 1);
        }

        static void PrintItems(List<Item> list, Func<Item, bool> condition)
        {
            var selectedItems = list.Where(condition);

            foreach (var item in selectedItems)
            {
                Console.WriteLine("{0}, {1}", item.Id, item.Name);
            }
        }
    }
}