using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Civia.CommandApp
{
    public class RemoveOrderCommand : OrderCommand
    {
        public override void Execute(List<MenuItem> orders, MenuItem item)
        {
            orders.Remove(orders.Where(o => o.Item == item.Item).First());
        }
    }
}
