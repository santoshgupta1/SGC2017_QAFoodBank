using System;

namespace QAFoodBank
{
    public class Item
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ItemCategory Category { get; set; }
        public string Quantity { get; set; }
        public ItemPriority Priority { get; set; }
        public string Picture { get; set; }
        public string Query { get; set; }
        public string CompanyId { get; set; }
    }
}
