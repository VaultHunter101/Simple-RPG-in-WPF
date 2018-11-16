using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    class InventoryItem
    {
        public Item Details { get; set; }
        public int Quantity { get; set; }

        public InventoryItem(Item details, int quantity)
        {
            Details = details;
            Quantity = quantity;
        }



    }
}
