using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Civia.CommandApp
{
    public class ModifyOrderCommand : OrderCommand
    {
        public override void Execute(List<MenuItem> orders, MenuItem xItem)
        {
            var item = orders.Where(o => o.Item == xItem.Item).First();
            item.Quantity = xItem.Quantity;
            item.Tags = xItem.Tags;
            item.TableNumber = xItem.TableNumber;
        }
    }
}
