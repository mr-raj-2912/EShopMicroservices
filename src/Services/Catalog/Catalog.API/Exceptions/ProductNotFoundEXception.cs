namespace Catalog.API.Exceptions
{
	public class ProductNotFoundEXception : Exception
	{
        public ProductNotFoundEXception() : base("Product Not Found!")
        {
        }
    }
}
