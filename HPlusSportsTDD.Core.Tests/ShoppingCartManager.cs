namespace HPlusSportsTDD.Core.Tests
{
    internal class ShoppingCartManager
    {
        public ShoppingCartManager()
        {
        }

        internal AddToCartResponse AddToCart(AddToCartRequest request)
        {
            return new AddToCartResponse()
            {
                Items = new AddToCartItem[]
                {
                    request.item
                }
            };
        }
    }
}