using System;
using System.Collections.Generic;
using System.Text;

namespace Civia.CommandApp
{
    public class MenuItem
    {
        public string Item { get; set; }
        public int Quantity { get; set; }
        public int TableNumber { get; set; }
        public List<Tag> Tags { get; set; }

        public void DisplayOrder()
        {
            Console.WriteLine("Table No: " + TableNumber);
            Console.WriteLine("Item: " + Item);
            Console.WriteLine("Quantité: " + Quantity);
            Console.Write("\tTags: ");
            foreach (var item in Tags)
            {
                Console.Write(item.Libelle + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
