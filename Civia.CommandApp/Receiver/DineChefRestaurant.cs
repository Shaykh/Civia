using System;
using System.Collections.Generic;
using System.Text;

namespace Civia.CommandApp
{
    public class DineChefRestaurant
    {
        public List<MenuItem> Orders { get; set; }

        public DineChefRestaurant()
        {
            Orders = new List<MenuItem>();
        }

        public void ExecuteCommand(OrderCommand command, MenuItem item)
        {
            command.Execute(Orders, item);
        }

        public void ShowOrders()
        {
            foreach (var item in Orders)
            {
                item.DisplayOrder();
            }
        }
    }
}
