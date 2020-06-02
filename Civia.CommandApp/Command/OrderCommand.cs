using System;
using System.Collections.Generic;
using System.Text;

namespace Civia.CommandApp
{
    public abstract class OrderCommand
    {
        public abstract void Execute(List<MenuItem> orders, MenuItem item);
    }
}
