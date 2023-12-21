using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Play.Inventory.Service.Entities
{
    public class InventoryItem
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid CatalogItemId { get; set; }
        public int Quantity { get; set; }
        public DateTimeOffset AcquiredDate { get; set; }
    }
}