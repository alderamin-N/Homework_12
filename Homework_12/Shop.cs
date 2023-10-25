using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12
{
    internal class Shop
    {
        public ObservableCollection<Item> Items { get; } = new ObservableCollection<Item>();
        private int _lastId = 0;

        public void Add()
        { 
            Item item = new Item();
            item.Id = _lastId++;
            _lastId += 1;
            item.Name = $"Товар от {DateTime.Now}";
            Items.Add(item);
        }
        public void Remove(int id)
        {
            Item currentItem = null;
            foreach (Item item in Items)
            {
                if (item.Id == id)
                {
                    currentItem = item;
                    break;
                }
            }
            if (currentItem != null)
            {
                Items.Remove(currentItem);
                return;
            }
            Console.WriteLine("Товара с таким id не существует");
        }
    }
}
