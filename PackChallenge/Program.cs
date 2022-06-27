using PackChallenge.Enum;
using PackChallenge.Services;
using System;
using System.Collections.Generic;

namespace PackChallenge
{
    class Program
    {
        static void Main(string[] args)
        {

            PackingService ps = new PackingService();

            var items = Items.GetValues(typeof(Items));
            foreach(var item in items)
            {

                Console.Write($"Input order count for {item}: ");
                int count = int.Parse(Console.ReadLine());
                Dictionary<int, int> result = new Dictionary<int, int>();
                var str = string.Empty;

                switch (item)
                {
                    case Items.Screw:
                        result = ps.GroupScrew(count);
                        break;
                    case Items.Nail:
                        result = ps.GroupNails(count);
                        break;
                    case Items.Hook:
                        result = ps.GroupHooks(count);
                        break;
                    default:
                        break;
                }

                foreach (var itemResult in result)
                {
                    str += $"{itemResult.Key}'s : {itemResult.Value} packs = {ps.GetPrice((Items)item, itemResult.Key, itemResult.Value)} \n";
                }
                Console.Write(str);
            }

            Console.ReadLine();
        }


    }
}
