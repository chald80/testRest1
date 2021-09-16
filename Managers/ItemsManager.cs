using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testRest1.Models;

namespace testRest1.Managers
{
    public class ItemsManager
    {
        private static int _nextId = 1;
        private static readonly List<Item> Data = new List<Item>
        {
            new Item {Id = _nextId++, Name = "C# is nice", ItemQuality = 4, Quantity = 10},
            new Item {Id=_nextId++, Name = "Python is even nicer", ItemQuality = 7, Quantity = 14}
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers
        };

        public List<Item> GetAll()
        {
            return new List<Item>(Data);
            // copy constructor
            // Callers should no get a reference to the Data object, but rather get a copy
        }

        public Item GetById(int id)
        {
            return Data.Find(item => item.Id == id);
        }

        public Item Add(Item newItem)
        {
            newItem.Id = _nextId++;
            Data.Add(newItem);
            return newItem;
        }

        public Item Delete(int id)
        {
            Item item = Data.Find(item1 => item1.Id == id);
            if (item == null) return null;
            Data.Remove(item);
            return item;
        }

        public Item Update(int id, Item updates)
        {
            Item item = Data.Find(item1 => item1.Id == id);
            if (item == null) return null;
            item.Name = updates.Name;
            item.ItemQuality = updates.ItemQuality;
            item.Quantity = updates.Quantity;
            return item;
        }
    }
}
