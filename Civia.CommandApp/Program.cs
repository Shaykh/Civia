using System;
using System.Collections.Generic;

namespace Civia.CommandApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DineChef dineChef = new DineChef();
            dineChef.SetOrderCommand(1);
            dineChef.SetMenuItem(new MenuItem()
            {
                TableNumber = 1, Item = "Super Mega Burger", Quantity = 1,
                Tags = new List<Tag>() { 
                    new Tag() { Libelle = "Jalapenos" } ,
                    new Tag() { Libelle = "Cheese" },
                    new Tag() { Libelle = "Tomato" }
                }
            });
            dineChef.ExecuteCommand();

            dineChef.SetOrderCommand(1);
            dineChef.SetMenuItem(new MenuItem()
            {
                TableNumber = 1,
                Item = "Cheese Sandwich",
                Quantity = 1,
                Tags = new List<Tag>() {
                    new Tag() { Libelle = "Spicy Mayo" } 
                }
            });
            dineChef.ExecuteCommand();
            dineChef.ShowCurrentOrder();

            dineChef.SetOrderCommand(3);
            dineChef.SetMenuItem(new MenuItem()
            {
                TableNumber = 1,
                Item = "Cheese Sandwich"
            });
            dineChef.ExecuteCommand();
            dineChef.ShowCurrentOrder();

            dineChef.SetOrderCommand(2);
            dineChef.SetMenuItem(new MenuItem()
            {
                TableNumber = 1,
                Item = "Super Mega Burger",
                Quantity = 1,
                Tags = new List<Tag>() {
                    new Tag() { Libelle = "Jalapenos" } ,
                    new Tag() { Libelle = "Cheese" }
                }
            });
            dineChef.ExecuteCommand();
            dineChef.ShowCurrentOrder();
            Console.ReadKey();
        }
    }
}
