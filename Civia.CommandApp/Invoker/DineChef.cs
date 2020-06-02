using System;
using System.Collections.Generic;
using System.Text;

namespace Civia.CommandApp
{
    public class DineChef
    {
        private DineChefRestaurant order;
        private OrderCommand orderCommand;
        private MenuItem menuItem;

        public DineChef()
        {
            order = new DineChefRestaurant();
        }

        public void SetOrderCommand(int dineCommand)
        {
            orderCommand = new DineTableCommand().GetDineCommand(dineCommand);
        }

        public void SetMenuItem(MenuItem item)
        {
            menuItem = item;
        }

        public void ExecuteCommand()
        {
            order.ExecuteCommand(orderCommand, menuItem);
        }

        public void ShowCurrentOrder()
        {
            order.ShowOrders();
        }
    }
}
