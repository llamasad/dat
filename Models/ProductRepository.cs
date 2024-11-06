namespace CRUID.Models
{
    public static class ProductRepository
    {
        public static readonly List<Product> _products = new List<Product>();


        public static IEnumerable<Product> Products { get { return _products; } }

        public static void AddNew(Product product) 
        {
            _products.Add(product);
        }
        public static void RemoveProduct(Product product)
        {
            _products.Remove(product);

        }
        public static void EditProduct(Product product)
        {
            Product productToEdit = _products.FirstOrDefault(p => p.Id == product.Id);
            if (productToEdit != null)
            {
                productToEdit.Name = product.Name;
                productToEdit.Description = product.Description;
                productToEdit.Price = product.Price;
                productToEdit.Quantity = product.Quantity;
            }

        }
        public static Product product(int productId)
        {
            return _products.FirstOrDefault(p => p.Id == productId);
        }

    }

}
