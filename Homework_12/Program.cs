using System.Threading.Channels;

namespace Homework_12
{
    internal class Program
    {
        private static Shop shop = new Shop();
        private static Customer customer = new Customer();
        static void Main(string[] args)
        {
            
            shop.Items.CollectionChanged += Items_CollectionChanged;
            
            
            while(true)
            {
               ConsoleKey key = Console.ReadKey().Key;
               if (key == ConsoleKey.A)
                {
                    shop.Add();
                    continue;
                }
                if (key == ConsoleKey.D)
                {
                    Console.WriteLine("Введите число:");
                    int number = int.Parse(Console.ReadLine());
                    shop.Remove(number);
                    continue;
                }
                if (key == ConsoleKey.X)
                {
                    return;
                }
            }

        }

        private static void Items_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                customer.OnItemChanged(false, e.NewItems[0] as Item);
                return;
            }
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                customer.OnItemChanged(true, e.OldItems[0] as Item);
                return;
            }

        }
    }
}