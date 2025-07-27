namespace quanlykho.Models
{
    public class ProductInventory
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int WarehouseId { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public int Quantity { get; set; }
    }
}
