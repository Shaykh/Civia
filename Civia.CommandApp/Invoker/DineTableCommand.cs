using System;
using System.Collections.Generic;
using System.Text;

namespace Civia.CommandApp
{
    public class DineTableCommand
    {
        public OrderCommand GetDineCommand(int dineCommand)
        {
            switch (dineCommand)
            {
                case 1:
                    return new NewOrderCommand();
                case 2:
                    return new ModifyOrderCommand();
                case 3:
                    return new RemoveOrderCommand();
                default:
                    return new NewOrderCommand();
            }
        }
    }
}
