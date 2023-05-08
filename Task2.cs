using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._04_dz
{
    class Backpack
    {
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Material { get; set; }
        public double Weight { get; set; }
        public double Capacity { get; set; }
        public List<Item> Contents { get; set; }

        public Backpack(string color, string brand, string material, double weight, double capacity)
        {
            Color = color;
            Brand = brand;
            Material = material;
            Weight = weight;
            Capacity = capacity;
            Contents = new List<Item>();
        }

        public void AddItem(Item item)
        {
            if (item.Volume > Capacity - GetTotalVolume())
            {
                throw new Exception("Рюкзак переповнений!");
            }
            Contents.Add(item);
            OnItemAdded(item);
        }

        public double GetTotalVolume()
        {
            double totalVolume = 0;
            foreach (Item item in Contents)
            {
                totalVolume += item.Volume;
            }
            return totalVolume;
        }

        public event Action<Item> ItemAdded;

        protected virtual void OnItemAdded(Item item)
        {
            if (ItemAdded != null)
            {
                ItemAdded(item);
            }
        }
    }

    class Item
    {
        public string Name { get; set; }
        public double Volume { get; set; }

        public Item(string name, double volume)
        {
            Name = name;
            Volume = volume;
        }
    }

    
    

    internal class Task2
    {
        public static void task2()
        {
            Backpack myBackpack = new Backpack("Червоний", "Nike", "Нейлон", 0.5, 20);

            myBackpack.ItemAdded += (item) =>
            {
                Console.WriteLine($"Додано {item.Name} ({item.Volume} л) в рюкзак!");
            };

            try
            {
                myBackpack.AddItem(new Item("Книга", 2));
                myBackpack.AddItem(new Item("Ноутбук", 3));
                myBackpack.AddItem(new Item("Вода", 1));
                myBackpack.AddItem(new Item("Фрукти", 0.5));
                myBackpack.AddItem(new Item("Хліб", 1));
                myBackpack.AddItem(new Item("Спальний мішок", 8));
                myBackpack.AddItem(new Item("Тент", 6));
                myBackpack.AddItem(new Item("Телескоп", 3));
                myBackpack.AddItem(new Item("Компас", 0.1));
                myBackpack.AddItem(new Item("Фонарик", 0.2));
                myBackpack.AddItem(new Item("Мачете", 2));
                myBackpack.AddItem(new Item("Картопляні чіпси", 0.5));
                myBackpack.AddItem(new Item("Батончики", 0.3));
                myBackpack.AddItem(new Item("Окуляри", 0.1));
                myBackpack.AddItem(new Item("Фотоапарат", 1));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
