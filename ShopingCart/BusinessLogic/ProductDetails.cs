namespace BusinessLogic
{
    public class ProductDetails
    {
        public string ProductId { get; set; }
        public string ProdctName { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal ProductDiscount { get; set; }
        public ProductTypeEnum ProductType { get; set; }
    }
}
