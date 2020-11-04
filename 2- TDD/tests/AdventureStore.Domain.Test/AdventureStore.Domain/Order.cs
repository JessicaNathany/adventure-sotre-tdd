using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventureStore.Domain
{
    public class Order
    {
        public Order()
        {
            _itemOrders = new List<ItemOrder>();
        }

        public double TotalPrice { get; private set; }

        public readonly List<ItemOrder> _itemOrders;

        public IReadOnlyCollection<ItemOrder> ItemsOrder => _itemOrders;

        public void AddItem(ItemOrder itemOrder)
        {
            _itemOrders.Add(itemOrder);
            TotalPrice = ItemsOrder.Sum(i => i.Quantity * i.UnitPrice);
        }

        public bool OrderClose(ItemOrder itemOrder, out string message)
        {
            message = "";

            if (itemOrder.InStock == false)
            {
                message = "This product is not in stock" ;
                return;
            }


            // 1º rule the product is inactive in the stock : first test
        }
    }

    public class ItemOrder
    {
        public Guid ProductId { get; private set; }

        public string Name { get; private set; }

        public double UnitPrice { get; private set; }

        public int Quantity { get; private set; }

        public Product Product { get; set; }

        public bool InStock { get; set; }

        public ItemOrder(Guid productId, string name, double unitPrice, int quantity)
        {
            ProductId = productId;
            Name = name;
            UnitPrice = unitPrice;
            Quantity = quantity;
        }
    }
}
