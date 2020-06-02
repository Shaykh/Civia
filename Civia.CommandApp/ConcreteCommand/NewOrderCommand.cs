using System;
using System.Collections.Generic;
using System.Text;

namespace Civia.CommandApp
{
    public class NewOrderCommand : OrderCommand
    {
        public override void Execute(List<MenuItem> orders, MenuItem item)
        {
            orders.Add(item);
        }
    }
}
