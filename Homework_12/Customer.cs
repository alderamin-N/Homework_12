using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12
{
    internal class Customer
    {
        public void OnItemChanged(bool isRemove, Item item)
        {
            if (isRemove)
            {
                Console.WriteLine($"Товар удален + {item.Id} + {item.Name}");
            }
            else
            {
                Console.WriteLine($"Товар добавлен + {item.Id} + {item.Name}");
            }                       
        }
    }
}
